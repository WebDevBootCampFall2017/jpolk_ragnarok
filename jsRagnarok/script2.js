var c=document.getElementById("intro");
var ctx=c.getContext("2d");
var requestAnimationFrame = window.requestAnimationFrame || 
                            window.mozRequestAnimationFrame || 
                            window.webkitRequestAnimationFrame || 
                            window.msRequestAnimationFrame;
var canvasWidth = c.width;
var canvasHeight = c.height;

var lineAni = function()
{
	ctx.clearRect(0, 0, canvasWidth, canvasHeight)
	ctx.beginPath();
	ctx.strokeStyle="#FFFFFF";
	ctx.moveTo(760,520);
	ctx.lineWidth = 1;
	var x1 = 760;
	var x2 = 760;
	ctx.lineTo(x1, 520);
	ctx.lineTo(x2, 520);
	x1--;
	x2++;
	ctx.stroke();
	ctx.closePath();
	if (x1 != 0 && x2 != 1520)
	{
		requestAnimationFrame(lineAni)
	}
}
lineAni();