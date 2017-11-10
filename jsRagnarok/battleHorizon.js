var canvas = document.getElementById("battle");
var ct = canvas.getContext("2d");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;
var canWidth = canvas.width
var canHeight = canvas.height

var background = function()
{
	ct.beginPath();
	ct.strokeStyle="#FFFFFF"
	ct.lineWidth = 3;
	ct.moveTo(0, canHeight * .3);
	ct.bezierCurveTo(0, canHeight * .287, canWidth, canHeight * .287, canWidth, canHeight * .3);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = 1;
	ct.moveTo(0, canHeight * .25);
	ct.lineTo(canWidth * .10, canHeight * .22);
	ct.lineTo(canWidth * .15, canHeight * .24);
	ct.lineTo(canWidth * .41, canHeight * .09);
	ct.lineTo(canWidth * .43, canHeight * .11);
	ct.stroke();
	
}

background();