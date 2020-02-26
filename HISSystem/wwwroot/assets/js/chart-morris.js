'use strict';
(function($) {
	/**
	  * Function written to load area hart behaving like line chart morris chart.
	**/
	if ($(".area-chart-morris").length > 0){
		Morris.Area({
		  element: $('.area-chart-morris'),
		  behaveLikeLine: true,
		  data: [
			{x: '2011 Q1', y: 3, z: 3},
			{x: '2011 Q2', y: 2, z: 1},
			{x: '2011 Q3', y: 2, z: 4},
			{x: '2011 Q4', y: 3, z: 3}
		  ],
		  xkey: 'x',
		  lineColors:['#7e8ac2','#5e6db3'],
		  ykeys: ['y', 'z'],
		  labels: ['Y', 'Z']
		});
	}

	/**
	  * Function written to load line morris chart.
	**/
	if ($(".line-chart-morris").length > 0){
		Morris.Line({
		  element: $('.line-chart-morris'),
		  data: [
			{ y: '2006', a: 100, b: 90 },
			{ y: '2007', a: 75,  b: 65 },
			{ y: '2008', a: 50,  b: 40 },
			{ y: '2009', a: 75,  b: 65 },
			{ y: '2010', a: 50,  b: 40 },
			{ y: '2011', a: 75,  b: 65 },
			{ y: '2012', a: 100, b: 90 }
		  ],
		  xkey: 'y',
		  ykeys: ['a', 'b'],
		  lineColors:['#7e8ac2','#5e6db3'],
		  labels: ['Series A', 'Series B']
		});
	}

	/**
	  * Function written to load simple bar morris chart.
	**/
	if ($(".simple-bar-chart-morris").length > 0){
		Morris.Bar({
		  element: $('.simple-bar-chart-morris'),
		  data: [
			{x: '2011 Q1', y: 3, z: 2, a: 3},
			{x: '2011 Q2', y: 2, z: null, a: 1},
			{x: '2011 Q3', y: 0, z: 2, a: 4},
			{x: '2011 Q4', y: 2, z: 4, a: 3}
		  ],
		  xkey: 'x',
		  ykeys: ['y', 'z', 'a'],
		  barColors:['#7e8ac2','#5e6db3','#00ca95'],
		  labels: ['Y', 'Z', 'A']
		}).on('click', function(i, row){
		  console.log(i, row);
		});
	}

	/**
	  * Function written to load bar morris chart.
	**/
	if ($(".bar-chart-morris").length > 0){
		Morris.Bar({
		  element: $('.bar-chart-morris'),
		  data: [
			{x: '2011 Q1', y: 0},
			{x: '2011 Q2', y: 1},
			{x: '2011 Q3', y: 2},
			{x: '2011 Q4', y: 3},
			{x: '2012 Q1', y: 4},
			{x: '2012 Q2', y: 5},
			{x: '2012 Q3', y: 6},
			{x: '2012 Q4', y: 7},
			{x: '2013 Q1', y: 8}
		  ],
		  xkey: 'x',
		  ykeys: ['y'],
		  labels: ['Y'],
		  barColors:['#5e6db3'],
		});
	}

	/**
	  * Function written to load displaying x_lables digonally morris chart.
	**/
	if ($(".bar-diagonal-morris").length > 0){	
		var day_data = [
		  {"period": "2012-10-01", "licensed": 3407, "sorned": 660},
		  {"period": "2012-09-30", "licensed": 3351, "sorned": 629},
		  {"period": "2012-09-29", "licensed": 3269, "sorned": 618},
		  {"period": "2012-09-20", "licensed": 3246, "sorned": 661},
		  {"period": "2012-09-19", "licensed": 3257, "sorned": 667},
		  {"period": "2012-09-18", "licensed": 3248, "sorned": 627},
		  {"period": "2012-09-17", "licensed": 3171, "sorned": 660},
		  {"period": "2012-09-16", "licensed": 3171, "sorned": 676},
		  {"period": "2012-09-15", "licensed": 3201, "sorned": 656},
		  {"period": "2012-09-10", "licensed": 3215, "sorned": 622}
		];
		Morris.Bar({
		  element: $('.bar-diagonal-morris'),
		  data: day_data,
		  barColors:['#5e6db3', '#7e8ac2'],
		  xkey: 'period',
		  ykeys: ['licensed', 'sorned'],
		  labels: ['Licensed', 'SORN'],
		  xLabelAngle: 60
		});
	}

	/**
	  * Function written to load decimal data morris chart.
	**/
	if ($(".decimal-data-morris").length > 0){	
		var decimal_data = [];
	    for (var x = 0; x <= 360; x += 10) {
	      decimal_data.push({
	        x: x,
	        y: 1.5 + 1.5 * Math.sin(Math.PI * x / 180).toFixed(4)
	      });
	    }
	    window.m = Morris.Line({
	      element: $('.decimal-data-morris'),
	      data: decimal_data,
	      xkey: 'x',
	      ykeys: ['y'],
	      labels: ['sin(x)'],
	      parseTime: false,
	      lineColors:['#5e6db3'],
	      hoverCallback: function (index, options, default_content, row) {
	        return default_content.replace("sin(x)", "1.5 + 1.5 sin(" + row.x + ")");
	      },
	      xLabelMargin: 10,
	      integerYLabels: true
	    });
	}

    /**
	  * Function written to load displaying x-labels diagonally morris chart.
	**/
    if ($(".x-labels-morris").length > 0){	
	    var day_data = [
		  {"period": "2012-10-30", "licensed": 3407, "sorned": 660},
		  {"period": "2012-09-30", "licensed": 3351, "sorned": 629},
		  {"period": "2012-09-29", "licensed": 3269, "sorned": 618},
		  {"period": "2012-09-20", "licensed": 3246, "sorned": 661},
		  {"period": "2012-09-19", "licensed": 3257, "sorned": 667},
		  {"period": "2012-09-18", "licensed": 3248, "sorned": 627},
		  {"period": "2012-09-17", "licensed": 3171, "sorned": 660},
		  {"period": "2012-09-16", "licensed": 3171, "sorned": 676},
		  {"period": "2012-09-15", "licensed": 3201, "sorned": 656},
		  {"period": "2012-09-10", "licensed": 3215, "sorned": 622}
		];
		Morris.Line({
		  element: $('.x-labels-morris'),
		  data: day_data,
		  xkey: 'period',
		  lineColors:['#7e8ac2','#5e6db3'],
		  ykeys: ['licensed', 'sorned'],
		  labels: ['Licensed', 'SORN'],
		  xLabelAngle: 60
		});
	}

	/**
	  * Function written to load formatting dates morris chart.
	**/
	if ($(".formatting-dates-morris").length > 0){	
	    var day_data = [
		  {"period": "2012-10-01", "licensed": 3407, "sorned": 660},
		  {"period": "2012-09-30", "licensed": 3351, "sorned": 629},
		  {"period": "2012-09-29", "licensed": 3269, "sorned": 618},
		  {"period": "2012-09-20", "licensed": 3246, "sorned": 661},
		  {"period": "2012-09-19", "licensed": 3257, "sorned": 667},
		  {"period": "2012-09-18", "licensed": 3248, "sorned": 627},
		  {"period": "2012-09-17", "licensed": 3171, "sorned": 660},
		  {"period": "2012-09-16", "licensed": 3171, "sorned": 676},
		  {"period": "2012-09-15", "licensed": 3201, "sorned": 656},
		  {"period": "2012-09-10", "licensed": 3215, "sorned": 622}
		];
		Morris.Line({
		  element: $('.formatting-dates-morris'),
		  data: day_data,
		  xkey: 'period',
		  lineColors:['#7e8ac2','#5e6db3'],
		  ykeys: ['licensed', 'sorned'],
		  labels: ['Licensed', 'SORN']
		});
	}

    /**
	  * Function written to load donut color morris chart.
	**/
    if ($(".donut-color-chart-morris").length > 0){
	    Morris.Donut({
	      element: $('.donut-color-chart-morris'),
	        data: [
			{value: 70, label: 'foo'},
			{value: 15, label: 'bar'},
			{value: 10, label: 'baz'},
			{value: 5, label: 'A really really long label'}
		  ],
		  backgroundColor: '#ccc',
		  labelColor: '#060',
		  colors:['#7e8ac2','#5e6db3','#fd7b6c','#31cff9'],
		  formatter: function (x) { return x + "%"}
	    }).on('click', function(i, row){
	      console.log(i, row);
	    });
	}
	/**
	  * Function written to load updating data morris chart.
	**/
	if ($(".updating-data-morris").length > 0){
		var nReloads = 0;
		var data = function(offset) {
		  var ret = [];
		  for (var x = 0; x <= 360; x += 10) {
			var v = (offset + x) % 360;
			ret.push({
			  x: x,
			  y: Math.sin(Math.PI * v / 180).toFixed(4),
			  z: Math.cos(Math.PI * v / 180).toFixed(4)
			});
		  }
		  return ret;
		}
		var graph = Morris.Line({
			element: $('.updating-data-morris'),
			data: data(0),
			xkey: 'x',
			ykeys: ['y', 'z'],
			labels: ['sin()', 'cos()'],
			parseTime: false,
			ymin: -1.0,
			ymax: 1.0,
			hideHover: true,
			lineColors:['#7e8ac2','#5e6db3'],
		});
		var update = function() {
		  nReloads++;
		  graph.setData(data(5 * nReloads));
		  $('.reloadStatus').text(nReloads + ' reloads');
		}
		setInterval(update, 100);
	}

	/**
	  * Function written to load stacked bar morris chart.
	**/
	if ($(".stacked-bar-chart-morris").length > 0){
		Morris.Bar({
		  element: $('.stacked-bar-chart-morris'),
		  data: [
			{x: '2011 Q1', y: 3, z: 2, a: 3},
			{x: '2011 Q2', y: 2, z: null, a: 1},
			{x: '2011 Q3', y: 0, z: 2, a: 4},
			{x: '2011 Q4', y: 2, z: 4, a: 3}
		  ],
		  xkey: 'x',
		  ykeys: ['y', 'z', 'a'],
		  labels: ['Y', 'Z', 'A'],
		  barColors:['#7e8ac2','#5e6db3','#00ca95'],
		  stacked: true
		});
	}
})(jQuery);