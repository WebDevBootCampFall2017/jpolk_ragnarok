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
	ct.lineWidth = 6;
	ct.lineCap = "round";
	ct.moveTo(0, canHeight * .3);
	ct.bezierCurveTo(canWidth * .30, canHeight * .267, canWidth * .70, canHeight * .267, canWidth, canHeight * .3);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = 2.9;
	ct.moveTo(0, canHeight * .25);
	ct.lineTo(canWidth * .10, canHeight * .22);
	ct.lineTo(canWidth * .15, canHeight * .24);
	ct.lineTo(canWidth * .41, canHeight * .09);
	ct.lineTo(canWidth * .45, canHeight * .105);
	ct.lineTo(canWidth * .56, canHeight * .02);
	ct.lineTo(canWidth * .59, canHeight * .02);
	ct.lineTo(canWidth * .60, canHeight * .01);
	ct.lineTo(canWidth * .73, canHeight * .19);
	ct.lineTo(canWidth * .745, canHeight * .19);
	ct.lineTo(canWidth * .792, canHeight * .25);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = 4;
	ct.moveTo(canWidth * .78, canHeight * .282);
	ct.lineTo(canWidth * .89, 0);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = .4;
	ct.moveTo(0, canHeight * .105);
	ct.lineTo(canWidth * .14, canHeight * .07);
	ct.lineTo(canWidth * .208, canHeight * .117);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = 1.2;
	ct.moveTo(canWidth * .132, canHeight * .23);
	ct.lineTo(canWidth * .26, canHeight * .04);
	ct.lineTo(canWidth * .36, canHeight * .04);
	ct.lineTo(canWidth * .41, 0);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.moveTo(canWidth * .512, 0);
	ct.lineTo(canWidth * .544, canHeight * .034);
	ct.stroke();
	ct.closePath();
	ct.beginPath();
	ct.lineWidth = .4;
	ct.moveTo(canWidth * .716, canHeight * .17);
	ct.lineTo(canWidth * .76, canHeight * .14);
	ct.lineTo(canWidth * .813, canHeight * .2);
	ct.stroke();
	ct.closePath();
}
background();




var moon = function()
{
	ct.beginPath();
	var moonGrad = ct.createRadialGradient(canWidth * .788, canHeight * .045, 3, canWidth * .79, canHeight * .052, 35);
	moonGrad.addColorStop(0, "indigo");
	moonGrad.addColorStop(0.2, "white");
	moonGrad.addColorStop(0.6, "indigo");
	moonGrad.addColorStop(1, "black");
	ct.fillStyle = moonGrad;
	ct.fillRect(canWidth * .69, 0, canWidth * .145, canHeight * .11);
	ct.stroke();
}

moon();