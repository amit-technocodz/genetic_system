using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class DynamicTemplateService
    {
        private IUnitOfWork db;
        public DynamicTemplateService(IUnitOfWork db)
        {
            this.db = db;
        }

        public bool AddTemplate(Template model)
        {
            try
            {
                db.Template.Insert(model);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Template> GetAllTemplates()
        {

            return db.Template.Get().Include(x => x.TemplateType).Include(x => x.SubTemplateType).Include(x => x.TemplateColumns).ThenInclude(x => x.TemplateField);
        }

        public Template GetTemplateByName(string temptype, string subtemptype)
        {
            return db.Template.Get().Include(x => x.TemplateType).Include(x => x.SubTemplateType).Where(x => (String.IsNullOrEmpty(temptype) || x.TemplateType.Name == temptype) && x.SubTemplateType.Name == subtemptype).Include(x => x.TemplateColumns).FirstOrDefault();
        }

        public Template GetTemplateByID(int Id)
        {
            return db.Template.Get().Where(x => x.ID == Id).Include(x => x.TemplateType).Include(x => x.SubTemplateType).Include(x => x.TemplateColumns).FirstOrDefault();
        }

        public bool SaveTemplateData(TemplateData templateData)
        {
            try
            {
                db.TemplateData.Insert(templateData);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool UpdateTemplateData(TemplateData templateData)
        {
            try
            {
                db.TemplateData.Update(templateData);
                db.TemplateData.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TemplateData> GetTemplateDataID(int Id)
        {
            var result = db.TemplateData.Get().Where(x => x.TemplateID == Id).ToList();

            if (result == null)
                return new List<TemplateData>();
            else
            { 
                for(int i = 0; i < result.Count(); i++)
                {
                    if(result[i].GeneID != null)
                    result[i].Genes = result[i].GeneID.Split(",");
                }
                return result;
            }
        }

        public List<TemplateColumn> GetTemplateColumnsByID(int Id)
        {
            var result = db.TemplateColumn.Get().Where(x => x.TemplateID == Id).Include(x => x.TemplateField).Include(x => x.Template).ToList();

            if (result == null)
                return new List<TemplateColumn>();
            else
                return result;
        }

        public bool RemoveTemplateDataByID(int Id)
        {
            var result = db.TemplateData.Get().Where(x => x.ID == Id).FirstOrDefault();
            result.IsActive = false;

            try
            {
                result.IsActive = false;
                db.TemplateData.Update(result);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
