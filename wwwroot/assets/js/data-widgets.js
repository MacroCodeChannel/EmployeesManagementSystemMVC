$(function() {
	"use strict";


// chart 1

var options = {
	series: [{
		name: "Total Views",
		data: [400, 555, 257, 640, 460, 671, 350]
	},{
		name: "Total Clicks",
		data: [400, 555, 257, 640, 460, 671, 350]
	}],
	chart: {
		type: "bar",
		//width: 100%,
		height: 180,
        stacked: true,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: 1,
		curve: "smooth"
	},
	colors: ["#fff", "rgba(255, 255, 255, 0.20)"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	fill: {
		opacity: 1
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart1"), options);
  chart.render();


  
// chart 2

var options = {
	series: [{
		name: "Total Views",
		data: [400, 555, 257, 640, 460, 671, 350]
	}],
	chart: {
		type: "line",
		//width: 100%,
		height: 180,
        stacked: true,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: 4,
		curve: "smooth"
	},
	colors: ["#fff"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	fill: {
		opacity: 1
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart2"), options);
  chart.render();



// chart 3

var options = {
	chart: {
		type: "line",
		//width: 100%,
		height: 180,
        stacked: true,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
    series: [{
        type: 'column',
        height: 280,
		name: "Total Views",
		data: [39, 19, 25, 16, 31, 39, 23]
	},
    { type: 'line',
		name: "Total Clicks",
		data: [29, 9, 15, 6, 21, 29, 13]
	}],
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: [1, 4],
		curve: "smooth"
	},
	colors: ["rgba(255, 255, 255, 0.20)", "#fff", ],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug"]
	},
	fill: {
		opacity: 1
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart3"), options);
  chart.render();



  
// chart 4

var options = {
	series: [{
		name: "Total Views",
		data: [39, 19, 35, 25, 31, 45]
	}],
	chart: {
		type: "area",
		//width: 100%,
		height: 180,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: ['4'],
		curve: "smooth",
        colors: ['#fff'],
	},
    fill: {
		type: 'gradient',
		gradient: {
		  shade: 'light',
		  type: 'vertical',
		  shadeIntensity: 0.5,
		  gradientToColors: ['#ffd200'],
		  inverseColors: false,
		  opacityFrom: 1,
		  opacityTo: 1,
		  //stops: [0, 100]
		}
	  },
    colors: ["#f7971e"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart4"), options);
  chart.render();




  // chart 5 

  $('#chart5').sparkline([5,8,7,10,9,10,8,6,4,6,8,7,6,8,9,10,8,6,4
], {
	type: 'bar',
	height: '35',
	barWidth: '2',
	resize: true,
	barSpacing: '4',
	barColor: '#fff'
});




 // chart 6 

$('.chart6').easyPieChart({
	easing: 'easeOutBounce',
	barColor : '#ffffff',
	lineWidth: 10,
	trackColor : 'rgba(255, 255, 255, 0.12)',
	scaleColor: false,
	onStep: function(from, to, percent) {
	$(this.el).find('.w_percent').text(Math.round(percent));
  }
}); 




  
// chart 7

var options = {
	series: [{
		name: "Total Views",
		data: [39, 19, 35, 25, 31, 45]
	}],
	chart: {
		type: "area",
		//width: 100%,
		height: 60,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: ['0'],
		curve: "smooth",
        colors: ['#fff'],
	},
    fill: {
		type: 'gradient',
		gradient: {
		  shade: 'light',
		  type: 'vertical',
		  shadeIntensity: 0.5,
		  gradientToColors: ['#08a50e'],
		  inverseColors: false,
		  opacityFrom: 1,
		  opacityTo: 1,
		  //stops: [0, 100]
		}
	  },
    colors: ["#cddc35"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart7"), options);
  chart.render();


  
  
// chart 8

var options = {
	series: [{
		name: "Total Views",
		data: [39, 19, 35, 25, 31, 45]
	}],
	chart: {
		type: "area",
		//width: 100%,
		height: 60,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: ['0'],
		curve: "smooth",
        colors: ['#fff'],
	},
    fill: {
		type: 'gradient',
		gradient: {
		  shade: 'light',
		  type: 'vertical',
		  shadeIntensity: 0.5,
		  gradientToColors: ['#d13adf'],
		  inverseColors: false,
		  opacityFrom: 1,
		  opacityTo: 1,
		  //stops: [0, 100]
		}
	  },
    colors: ["#8f50ff"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart8"), options);
  chart.render();




  
// chart 9

var options = {
	series: [{
		name: "Total Views",
		data: [39, 19, 35, 25, 31, 45]
	}],
	chart: {
		type: "area",
		//width: 100%,
		height: 60,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: ['0'],
		curve: "smooth",
        colors: ['#fff'],
	},
    fill: {
		type: 'gradient',
		gradient: {
		  shade: 'light',
		  type: 'vertical',
		  shadeIntensity: 0.5,
		  gradientToColors: ['#f1076f'],
		  inverseColors: false,
		  opacityFrom: 1,
		  opacityTo: 1,
		  //stops: [0, 100]
		}
	  },
    colors: ["#ff5447"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart9"), options);
  chart.render();


  
  
// chart 10

var options = {
	series: [{
		name: "Total Views",
		data: [39, 19, 35, 25, 31, 45]
	}],
	chart: {
		type: "area",
		//width: 100%,
		height: 60,
		toolbar: {
			show: !1
		},
		zoom: {
			enabled: !1
		},
		dropShadow: {
			enabled: 0,
			top: 3,
			left: 14,
			blur: 4,
			opacity: .12,
			color: "#fff"
		},
		sparkline: {
			enabled: !0
		}
	},
	markers: {
		size: 0,
		colors: ["#fff"],
		strokeColors: "#fff",
		strokeWidth: 2,
		hover: {
			size: 7
		}
	},
	plotOptions: {
		bar: {
			horizontal: !1,
			columnWidth: "35%",
			//endingShape: "rounded"
		}
	},
	dataLabels: {
		enabled: !1
	},
	stroke: {
		show: !0,
		width: ['0'],
		curve: "smooth",
        colors: ['#fff'],
	},
    fill: {
		type: 'gradient',
		gradient: {
		  shade: 'light',
		  type: 'vertical',
		  shadeIntensity: 0.5,
		  gradientToColors: ['#0072ff'],
		  inverseColors: false,
		  opacityFrom: 1,
		  opacityTo: 1,
		  //stops: [0, 100]
		}
	  },
    colors: ["#00c8ff"],
	xaxis: {
		categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
	},
	tooltip: {
		theme: "dark",
		fixed: {
			enabled: !1
		},
		x: {
			show: !1
		},
		y: {
			title: {
				formatter: function(e) {
					return ""
				}
			}
		},
		marker: {
			show: !1
		}
	}
  };

  var chart = new ApexCharts(document.querySelector("#chart10"), options);
  chart.render();




 // chart 11
	 
 var options = {
	chart: {
	  height: 200,
	  type: 'radialBar',
	  toolbar: {
		show: false
	  }
	},
	plotOptions: {
	  radialBar: {
		//startAngle: -135,
		//endAngle: 225,
		 hollow: {
		  margin: 0,
		  size: '75%',
		  background: 'transparent',
		  image: undefined,
		  imageOffsetX: 0,
		  imageOffsetY: 0,
		  position: 'front',
		  dropShadow: {
			enabled: true,
			top: 3,
			left: 0,
			blur: 4,
			opacity: 0.24
		  }
		},
		track: {
		  background: '#fff',
		  strokeWidth: '67%',
		  margin: 0, // margin is in pixels
		  dropShadow: {
			enabled: true,
			top: -3,
			left: 0,
			blur: 4,
			color: 'rgba(242, 14, 108, 0.65)',
			opacity: 0.35
		  }
		},
  
		dataLabels: {
		  showOn: 'always',
		  name: {
			offsetY: -0,
			show: false,
			color: '#212529',
			fontSize: '17px'
		  },
		  value: {
			formatter: function(val) {
			  return val + "%";
			},
		  offsetY: 8,
			color: '#212529',
			fontSize: '20px',
			show: true,
		  }
		}
	  }
	},
	fill: {
	  type: 'gradient',
	  gradient: {
		shade: 'light',
		type: 'horizontal',
		shadeIntensity: 0.5,
		gradientToColors: ['#f1076f'],
		inverseColors: false,
		opacityFrom: 1,
		opacityTo: 1,
		stops: [0, 100]
	  }
	},
	colors: ["#ff5447"],
	series: [75],
	stroke: {
	  lineCap: 'round'
	},
	labels: ['Percent'],
  
  }
  
  var chart = new ApexCharts(
	document.querySelector("#chart11"),
	options
  );
  
  chart.render();



 // chart 12
	 
 var options = {
	chart: {
	  height: 200,
	  type: 'radialBar',
	  toolbar: {
		show: false
	  }
	},
	plotOptions: {
	  radialBar: {
		//startAngle: -135,
		//endAngle: 225,
		 hollow: {
		  margin: 0,
		  size: '75%',
		  background: 'transparent',
		  image: undefined,
		  imageOffsetX: 0,
		  imageOffsetY: 0,
		  position: 'front',
		  dropShadow: {
			enabled: true,
			top: 3,
			left: 0,
			blur: 4,
			opacity: 0.24
		  }
		},
		track: {
		  background: '#fff',
		  strokeWidth: '67%',
		  margin: 0, // margin is in pixels
		  dropShadow: {
			enabled: true,
			top: -3,
			left: 0,
			blur: 4,
			color: 'rgba(0, 169, 255, 0.65)',
			opacity: 0.35
		  }
		},
  
		dataLabels: {
		  showOn: 'always',
		  name: {
			offsetY: -0,
			show: false,
			color: '#212529',
			fontSize: '17px'
		  },
		  value: {
			formatter: function(val) {
			  return val + "%";
			},
		  offsetY: 8,
			color: '#212529',
			fontSize: '20px',
			show: true,
		  }
		}
	  }
	},
	fill: {
	  type: 'gradient',
	  gradient: {
		shade: 'light',
		type: 'horizontal',
		shadeIntensity: 0.5,
		gradientToColors: ['#0072ff'],
		inverseColors: false,
		opacityFrom: 1,
		opacityTo: 1,
		stops: [0, 100]
	  }
	},
	colors: ["#00c8ff"],
	series: [65],
	stroke: {
	  lineCap: 'round'
	},
	labels: ['Percent'],
  
  }
  
  var chart = new ApexCharts(
	document.querySelector("#chart12"),
	options
  );
  
  chart.render();


  
 // chart 13
	 
 var options = {
	chart: {
	  height: 200,
	  type: 'radialBar',
	  toolbar: {
		show: false
	  }
	},
	plotOptions: {
	  radialBar: {
		//startAngle: -135,
		//endAngle: 225,
		 hollow: {
		  margin: 0,
		  size: '75%',
		  background: 'transparent',
		  image: undefined,
		  imageOffsetX: 0,
		  imageOffsetY: 0,
		  position: 'front',
		  dropShadow: {
			enabled: true,
			top: 3,
			left: 0,
			blur: 4,
			opacity: 0.24
		  }
		},
		track: {
		  background: '#fff',
		  strokeWidth: '67%',
		  margin: 0, // margin is in pixels
		  dropShadow: {
			enabled: true,
			top: -3,
			left: 0,
			blur: 4,
			color: 'rgba(254, 197, 7, 0.55)',
			opacity: 0.35
		  }
		},
  
		dataLabels: {
		  showOn: 'always',
		  name: {
			offsetY: -0,
			show: false,
			color: '#212529',
			fontSize: '17px'
		  },
		  value: {
			formatter: function(val) {
			  return val + "%";
			},
		  offsetY: 8,
			color: '#212529',
			fontSize: '20px',
			show: true,
		  }
		}
	  }
	},
	fill: {
	  type: 'gradient',
	  gradient: {
		shade: 'light',
		type: 'horizontal',
		shadeIntensity: 0.5,
		gradientToColors: ['#f7971e'],
		inverseColors: false,
		opacityFrom: 1,
		opacityTo: 1,
		stops: [0, 100]
	  }
	},
	colors: ["#ffd200"],
	series: [65],
	stroke: {
	  lineCap: 'round'
	},
	labels: ['Percent'],
  
  }
  
  var chart = new ApexCharts(
	document.querySelector("#chart13"),
	options
  );
  
  chart.render();




  
 // chart 14
	 
 var options = {
	chart: {
	  height: 200,
	  type: 'radialBar',
	  toolbar: {
		show: false
	  }
	},
	plotOptions: {
	  radialBar: {
		//startAngle: -135,
		//endAngle: 225,
		 hollow: {
		  margin: 0,
		  size: '75%',
		  background: 'transparent',
		  image: undefined,
		  imageOffsetX: 0,
		  imageOffsetY: 0,
		  position: 'front',
		  dropShadow: {
			enabled: true,
			top: 3,
			left: 0,
			blur: 4,
			opacity: 0.24
		  }
		},
		track: {
		  background: '#fff',
		  strokeWidth: '67%',
		  margin: 0, // margin is in pixels
		  dropShadow: {
			enabled: true,
			top: -3,
			left: 0,
			blur: 4,
			color: 'rgba(0, 128, 0, 0.56)',
			opacity: 0.35
		  }
		},
  
		dataLabels: {
		  showOn: 'always',
		  name: {
			offsetY: -0,
			show: false,
			color: '#212529',
			fontSize: '17px'
		  },
		  value: {
			formatter: function(val) {
			  return val + "%";
			},
		  offsetY: 8,
			color: '#212529',
			fontSize: '20px',
			show: true,
		  }
		}
	  }
	},
	fill: {
	  type: 'gradient',
	  gradient: {
		shade: 'light',
		type: 'horizontal',
		shadeIntensity: 0.5,
		gradientToColors: ['#08a50e'],
		inverseColors: false,
		opacityFrom: 1,
		opacityTo: 1,
		stops: [0, 100]
	  }
	},
	colors: ["#cddc35"],
	series: [68],
	stroke: {
	  lineCap: 'round'
	},
	labels: ['Percent'],
  
  }
  
  var chart = new ApexCharts(
	document.querySelector("#chart14"),
	options
  );
  
  chart.render();

  
// chart 15

  var options = {
	chart: {
		height: 220,
		type: 'radialBar',
	},
	plotOptions: {
		radialBar: {
			//startAngle: -135,
			//endAngle: 135,
			hollow: {
			  margin: 0,
			  size: '70%',
			  background: 'transparent',
			  image: undefined,
			  imageOffsetX: 0,
			  imageOffsetY: 0,
			  position: 'front',
			  dropShadow: {
				enabled: true,
				top: 3,
				left: 0,
				blur: 4,
				opacity: 0.24
			  }
			},
			track: {
			  background: 'rgba(255, 255, 255, 0.12)',
			  strokeWidth: '0%',
			  margin: 0, // margin is in pixels
			  dropShadow: {
				enabled: true,
				top: -3,
				left: 0,
				blur: 4,
				opacity: 0.35
			  }
			},
			dataLabels: {
				name: {
					show: false,
					fontSize: '14px',
					color: '#000',
					offsetY: -0
				},
				value: {
					offsetY: 8,
					fontSize: '25px',
					color: '#000',
					formatter: function (val) {
						return val + "%";
					}
				}
			}
		}
	},
	fill: {
		type: 'gradient',
		gradient: {
			shade: 'dark',
			shadeIntensity: 0.15,
			gradientToColors: ['#f1076f'],
			inverseColors: false,
			opacityFrom: 1,
			opacityTo: 1,
			stops: [0, 50, 65, 91]
		},
	},
	stroke: {
		dashArray: 4
	},
	colors: ["#ff5447"],
	series: [82],
	labels: ['Median Ratio'],
	
}

var chart = new ApexCharts(
	document.querySelector("#chart15"),
	options
);

chart.render();

// window.setInterval(function () {
//     chart.updateSeries([Math.floor(Math.random() * (100 - 1 + 1)) + 1])
// }, 2000)



// chart 16

var options = {
	chart: {
		height: 220,
		type: 'radialBar',
	},
	plotOptions: {
		radialBar: {
			//startAngle: -135,
			//endAngle: 135,
			hollow: {
			  margin: 0,
			  size: '70%',
			  background: 'transparent',
			  image: undefined,
			  imageOffsetX: 0,
			  imageOffsetY: 0,
			  position: 'front',
			  dropShadow: {
				enabled: true,
				top: 3,
				left: 0,
				blur: 4,
				opacity: 0.24
			  }
			},
			track: {
			  background: 'rgba(255, 255, 255, 0.12)',
			  strokeWidth: '0%',
			  margin: 0, // margin is in pixels
			  dropShadow: {
				enabled: true,
				top: -3,
				left: 0,
				blur: 4,
				opacity: 0.35
			  }
			},
			dataLabels: {
				name: {
					show: false,
					fontSize: '14px',
					color: '#000',
					offsetY: -0
				},
				value: {
					offsetY: 8,
					fontSize: '25px',
					color: '#000',
					formatter: function (val) {
						return val + "%";
					}
				}
			}
		}
	},
	fill: {
		type: 'gradient',
		gradient: {
			shade: 'dark',
			shadeIntensity: 0.15,
			gradientToColors: ['#00c8ff'],
			inverseColors: false,
			opacityFrom: 1,
			opacityTo: 1,
			stops: [0, 50, 65, 91]
		},
	},
	stroke: {
		dashArray: 4
	},
	colors: ["#0072ff"],
	series: [85],
	labels: ['Median Ratio'],
	
}

var chart = new ApexCharts(
	document.querySelector("#chart16"),
	options
);

chart.render();

// window.setInterval(function () {
//     chart.updateSeries([Math.floor(Math.random() * (100 - 1 + 1)) + 1])
// }, 2000)



  
// chart 17

var options = {
	chart: {
		height: 220,
		type: 'radialBar',
	},
	plotOptions: {
		radialBar: {
			//startAngle: -135,
			//endAngle: 135,
			hollow: {
			  margin: 0,
			  size: '70%',
			  background: 'transparent',
			  image: undefined,
			  imageOffsetX: 0,
			  imageOffsetY: 0,
			  position: 'front',
			  dropShadow: {
				enabled: true,
				top: 3,
				left: 0,
				blur: 4,
				opacity: 0.24
			  }
			},
			track: {
			  background: 'rgba(255, 255, 255, 0.12)',
			  strokeWidth: '0%',
			  margin: 0, // margin is in pixels
			  dropShadow: {
				enabled: true,
				top: -3,
				left: 0,
				blur: 4,
				opacity: 0.35
			  }
			},
			dataLabels: {
				name: {
					show: false,
					fontSize: '14px',
					color: '#000',
					offsetY: -0
				},
				value: {
					offsetY: 8,
					fontSize: '25px',
					color: '#000',
					formatter: function (val) {
						return val + "%";
					}
				}
			}
		}
	},
	fill: {
		type: 'gradient',
		gradient: {
			shade: 'dark',
			shadeIntensity: 0.15,
			gradientToColors: ['#08a50e'],
			inverseColors: false,
			opacityFrom: 1,
			opacityTo: 1,
			stops: [0, 50, 65, 91]
		},
	},
	stroke: {
		dashArray: 4
	},
	colors: ["#cddc35"],
	series: [79],
	labels: ['Median Ratio'],
	
}

var chart = new ApexCharts(
	document.querySelector("#chart17"),
	options
);

chart.render();

// window.setInterval(function () {
//     chart.updateSeries([Math.floor(Math.random() * (100 - 1 + 1)) + 1])
// }, 2000)


 
// chart 18

var options = {
	chart: {
		height: 220,
		type: 'radialBar',
	},
	plotOptions: {
		radialBar: {
			//startAngle: -135,
			//endAngle: 135,
			hollow: {
			  margin: 0,
			  size: '70%',
			  background: 'transparent',
			  image: undefined,
			  imageOffsetX: 0,
			  imageOffsetY: 0,
			  position: 'front',
			  dropShadow: {
				enabled: true,
				top: 3,
				left: 0,
				blur: 4,
				opacity: 0.24
			  }
			},
			track: {
			  background: 'rgba(255, 255, 255, 0.12)',
			  strokeWidth: '0%',
			  margin: 0, // margin is in pixels
			  dropShadow: {
				enabled: true,
				top: -3,
				left: 0,
				blur: 4,
				opacity: 0.35
			  }
			},
			dataLabels: {
				name: {
					show: false,
					fontSize: '14px',
					color: '#000',
					offsetY: -0
				},
				value: {
					offsetY: 8,
					fontSize: '25px',
					color: '#000',
					formatter: function (val) {
						return val + "%";
					}
				}
			}
		}
	},
	fill: {
		type: 'gradient',
		gradient: {
			shade: 'dark',
			shadeIntensity: 0.15,
			gradientToColors: ['#8f50ff'],
			inverseColors: false,
			opacityFrom: 1,
			opacityTo: 1,
			stops: [0, 50, 65, 91]
		},
	},
	stroke: {
		dashArray: 4
	},
	colors: ["#d13adf"],
	series: [90],
	labels: ['Median Ratio'],
	
}

var chart = new ApexCharts(
	document.querySelector("#chart18"),
	options
);

chart.render();

// window.setInterval(function () {
//     chart.updateSeries([Math.floor(Math.random() * (100 - 1 + 1)) + 1])
// }, 2000)











});