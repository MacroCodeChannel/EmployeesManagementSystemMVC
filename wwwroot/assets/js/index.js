$(function() {
    "use strict";


    

  
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

  var chart = new ApexCharts(document.querySelector("#charta"), options);
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

  var chart = new ApexCharts(document.querySelector("#chartb"), options);
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

  var chart = new ApexCharts(document.querySelector("#chartc"), options);
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

  var chart = new ApexCharts(document.querySelector("#chartd"), options);
  chart.render();





















    // chart 1

    var ctx = document.getElementById('chart1').getContext('2d');

    var gradientStroke1 = ctx.createLinearGradient(0, 0, 0, 300);
            gradientStroke1.addColorStop(0, 'rgba(255, 255, 0, 0.5)');  
            gradientStroke1.addColorStop(1, 'rgba(233, 30, 99, 0.0)'); 

        var gradientStroke2 = ctx.createLinearGradient(0, 0, 0, 300);
            gradientStroke2.addColorStop(0, '#ffff00');  
            gradientStroke2.addColorStop(1, '#e91e63'); 


        var gradientStroke3 = ctx.createLinearGradient(0, 0, 0, 300);
            gradientStroke3.addColorStop(0, 'rgba(0, 114, 255, 0.5)');  
            gradientStroke3.addColorStop(1, 'rgba(0, 200, 255, 0.0)'); 

        var gradientStroke4 = ctx.createLinearGradient(0, 0, 0, 300);
            gradientStroke4.addColorStop(0, '#0072ff');  
            gradientStroke4.addColorStop(1, '#00c8ff'); 

    var myChart = new Chart(ctx, {
      type: 'line',
      data: {
        labels: ['Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa', 'Su'],
        datasets: [{
          label: 'Visits',
          data: [33, 43, 43, 63, 53, 76, 63],
          backgroundColor: gradientStroke1,
          borderColor: gradientStroke2,
          pointRadius :"0",
          pointHoverRadius:"0",
          borderWidth: 5
        }, {
          label: 'Sales',
          data: [43, 59, 67, 91, 83, 106, 93],
          backgroundColor: gradientStroke3,
          borderColor: gradientStroke4,
          pointRadius :"0",
          pointHoverRadius:"0",
          borderWidth: 5
        }]
      },
      options:{
        maintainAspectRatio: false,
        legend: {
            position: 'bottom',
            display: false,
            labels: {
              boxWidth:8
            }
          },
          tooltips: {
            displayColors:false,
          },	
        scales: {
            xAxes: [{
              barPercentage: .5
            }]
           }
      }
    }); 

	  
	 // chart 2
	 
   var ctx = document.getElementById('chart2').getContext('2d');

   var gradientStroke = ctx.createLinearGradient(0, 0, 0, 300);
       gradientStroke.addColorStop(0, '#08a50e');  
       gradientStroke.addColorStop(1, '#cddc35'); 

   var myChart = new Chart(ctx, {
     type: 'bar',
     data: {
       labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
       datasets: [{
         label: 'Sales',
         data: [9, 7, 14, 10, 12, 8],
         backgroundColor: gradientStroke,
         hoverBackgroundColor: gradientStroke,
         borderColor: "#fff",
         pointRadius :6,
         pointHoverRadius :6,
         pointHoverBackgroundColor: "#fff",
         borderWidth: 2

       }]
     },
   options: {
     maintainAspectRatio: false,
     legend: {
       display: false,
       labels: {
       fontColor: '#ddd',  
       boxWidth:40
       }
     },
     tooltips: {
       displayColors:false
     },	
     scales: {
       xAxes: [{
         barPercentage: .4,
       ticks: {
         beginAtZero:true,
         fontColor: '#757575'
       },
       gridLines: {
         display: false ,
         color: "rgba(0, 0, 0, 0.1)"
       },
       }],
        yAxes: [{
       ticks: {
         beginAtZero:true,
         fontColor: '#757575'
       },
       gridLines: {
         display: true ,
         color: "rgba(0, 0, 0, 0.1)"
       },
       }]
      }

    }
   }); 

   

// chart 3
	 
var ctx = document.getElementById('chart3').getContext('2d');

var gradientStroke = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke.addColorStop(0, '#ffff00');  
gradientStroke.addColorStop(1, '#e91e63'); 

var gradientStroke2 = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke2.addColorStop(0, 'rgba(255, 255, 0, 0.3)');  
gradientStroke2.addColorStop(1, 'rgba(233, 30, 99, 0.0)'); 

var myChart = new Chart(ctx, {
type: 'line',
data: {
labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Aug"],
datasets: [{
  label: 'Old Visitor',
  data: [3, 6, 10, 6, 11, 5, 8],
  backgroundColor: gradientStroke2,
  borderColor: gradientStroke,
  pointRadius :0,
  pointHoverRadius :0,
  pointHoverBackgroundColor: "#fff",
  borderWidth: 5,

}]
},
options: {
maintainAspectRatio: false,
legend: {
display: false,
labels: {
fontColor: '#ddd',  
boxWidth:40
}
},
tooltips: {
displayColors:false
},	
scales: {
xAxes: [{
  display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}],
 yAxes: [{
   display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}]
}

}
});  



// chart 4

var ctx = document.getElementById('chart4').getContext('2d');

var gradientStroke = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke.addColorStop(0, '#21d4fd');  
gradientStroke.addColorStop(1, '#b721ff'); 

var gradientStroke2 = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke2.addColorStop(0, 'rgba(33, 212, 253, 0.3)');  
gradientStroke2.addColorStop(1, 'rgba(183, 33, 255, 0.0)');

var myChart = new Chart(ctx, {
type: 'line',
data: {
labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Aug"],
datasets: [{
  label: 'Old Visitor',
  data: [12, 6, 10, 6, 11, 5, 8],
  backgroundColor: gradientStroke2,
  borderColor: gradientStroke,
  pointRadius :0,
  pointHoverRadius :0,
  pointHoverBackgroundColor: "#fff",
  borderWidth: 5,

}]
},
options: {
maintainAspectRatio: false,
legend: {
display: false,
labels: {
fontColor: '#ddd',  
boxWidth:40
}
},
tooltips: {
displayColors:false
},	
scales: {
xAxes: [{
  display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}],
 yAxes: [{
   display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}]
}

}
});


// chart 5

var ctx = document.getElementById('chart5').getContext('2d');



var gradientStroke = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke.addColorStop(0, '#2af598');  
gradientStroke.addColorStop(1, '#009efd'); 

var gradientStroke2 = ctx.createLinearGradient(0, 0, 0, 300);
gradientStroke2.addColorStop(0, 'rgba(42, 245, 152, 0.3)');  
gradientStroke2.addColorStop(1, 'rgba(0, 158, 253, 0.0)'); 

var myChart = new Chart(ctx, {
type: 'line',
data: {
labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Aug"],
datasets: [{
  label: 'Old Visitor',
  data: [8, 6, 8, 6, 12, 5, 13],
  backgroundColor: gradientStroke2,
  borderColor: gradientStroke,
  pointRadius :0,
  pointHoverRadius :0,
  pointHoverBackgroundColor: "#fff",
  borderWidth: 5,

}]
},
options: {
maintainAspectRatio: false,
legend: {
display: false,
labels: {
fontColor: '#ddd',  
boxWidth:40
}
},
tooltips: {
displayColors:false
},	
scales: {
xAxes: [{
  display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}],
 yAxes: [{
   display: false,
ticks: {
  beginAtZero:true,
  fontColor: '#ddd'
},
gridLines: {
  display: true ,
  color: "rgba(221, 221, 221, 0.08)"
},
}]
}

}
});   




// chart 6

var ctx = document.getElementById("chart6").getContext('2d');

var gradientStroke1 = ctx.createLinearGradient(0, 0, 0, 300);
    gradientStroke1.addColorStop(0, '#fc4a1a');
    gradientStroke1.addColorStop(1, '#f7b733');

var gradientStroke2 = ctx.createLinearGradient(0, 0, 0, 300);
    gradientStroke2.addColorStop(0, '#4776e6');
    gradientStroke2.addColorStop(1, '#8e54e9');


var gradientStroke3 = ctx.createLinearGradient(0, 0, 0, 300);
    gradientStroke3.addColorStop(0, '#ee0979');
    gradientStroke3.addColorStop(1, '#ff6a00');
  
var gradientStroke4 = ctx.createLinearGradient(0, 0, 0, 300);
    gradientStroke4.addColorStop(0, '#42e695');
    gradientStroke4.addColorStop(1, '#3bb2b8');

    var myChart = new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: ["Chrome", "Opera", "Firefox"],
        datasets: [{
          backgroundColor: [
            gradientStroke3,
            gradientStroke2,
            gradientStroke4
          ],
          hoverBackgroundColor: [
            gradientStroke3,
            gradientStroke2,
            gradientStroke4
          ],
          data: [25, 25, 25],
    borderWidth: [1, 1, 1]
        }]
      },
      options: {
    maintainAspectRatio: false,
    cutoutPercentage: 75,
          legend: {
      position: 'bottom',
            display: false,
      labels: {
              boxWidth:8
            }
          },
    tooltips: {
      displayColors:false,
    }
      }
    });




 // chart 7
	 
 var options = {
  chart: {
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
  document.querySelector("#chart7"),
  options
);

chart.render();



// chart 8

var options = {
  chart: {
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
  series: [45],
  stroke: {
    lineCap: 'round'
  },
  labels: ['Percent'],

}

var chart = new ApexCharts(
  document.querySelector("#chart8"),
  options
);

chart.render();



// chart 9

var options = {
  chart: {
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
  series: [55],
  stroke: {
    lineCap: 'round'
  },
  labels: ['Percent'],

}

var chart = new ApexCharts(
  document.querySelector("#chart9"),
  options
);

chart.render();


// chart 10

var options = {
  chart: {
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
      gradientToColors: ['#cddc35'],
      inverseColors: false,
      opacityFrom: 1,
      opacityTo: 1,
      stops: [0, 100]
    }
  },
  colors: ["#08a50e"],
  series: [80],
  stroke: {
    lineCap: 'round'
  },
  labels: ['Percent'],

}

var chart = new ApexCharts(
  document.querySelector("#chart10"),
  options
);

chart.render();



// chart 11

var options = {
  chart: {
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
      gradientToColors: ['#00dbde'],
      inverseColors: false,
      opacityFrom: 1,
      opacityTo: 1,
      stops: [0, 100]
    }
  },
  colors: ["#fc00ff"],
  series: [65],
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
    height: 180,
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
        size: '70%',
        background: 'transparent',
        image: undefined,
        imageOffsetX: 0,
        imageOffsetY: 0,
        position: 'front',
        dropShadow: {
          enabled: false,
          top: 3,
          left: 0,
          blur: 4,
          opacity: 0.24
        }
      },
      track: {
        background: '#eee',
        strokeWidth: '67%',
        margin: 0, // margin is in pixels
        dropShadow: {
          enabled: false,
          top: -3,
          left: 0,
          blur: 4,
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
      gradientToColors: ['#8f50ff'],
      inverseColors: false,
      opacityFrom: 1,
      opacityTo: 1,
      stops: [0, 100]
    }
  },
  colors: ["#d13adf"],
  series: [70],
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











// worl map

jQuery('#geographic-map-2').vectorMap(
{
    map: 'world_mill_en',
    backgroundColor: 'transparent',
    borderColor: '#818181',
    borderOpacity: 0.25,
    borderWidth: 1,
    zoomOnScroll: false,
    color: '#009efb',
    regionStyle : {
        initial : {
          fill : '#ccc'
        }
      },
      series: {
        regions: [{
            values: {
                IN:'#b659ff',
                US:'#2ccc72',
                RU:'#5a52db',
                AU:'#f09c15'
            }
        }]
    },
    markerStyle: {
      initial: {
				r: 9,
				'fill': '#fff',
				'fill-opacity':1,
				'stroke': '#000',
				'stroke-width' : 5,
				'stroke-opacity': 0.4
                },
                },
    enableZoom: true,
    hoverColor: '#009efb',
    markers : [{
        latLng : [21.00, 78.00],
        name : 'Lorem Ipsum Dollar'
      
      }],
    hoverOpacity: null,
    normalizeFunction: 'linear',
    scaleColors: ['#b6d6ff', '#005ace'],
    selectedColor: '#c9dfaf',
    selectedRegions: [],
    showTooltip: true,
});



   });	 
   