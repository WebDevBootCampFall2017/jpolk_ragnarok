var c=document.getElementById("intro");
var ctx=c.getContext("2d");

var introLine = function()
{
	ctx.beginPath();
	ctx.strokeStyle="#FFFFFF";
	ctx.moveTo(760,520);
	ctx.lineWidth = 1;
	var x1 = 760;
	var x2 = 760;
	var widthFlux = 2;
	var widthFlux2 = 140;
	var lineAni = function()
	{
		ctx.clearRect(0, 0, c.width, c.height);
		ctx.lineTo(x1, 520);
		ctx.lineTo(x2, 520);
		ctx.stroke();
		ctx.closePath();
		if (x1 != 0 && x2 != 1520)
		{
			x1-=5;
			x2+=5;
			window.setTimeout(lineAni, 7);
		}
		
	}
	var widthAniG = function()
	{
		ctx.clearRect(0, 0, c.width, c.height);
		ctx.beginPath();
		ctx.strokeStyle="#FFFFFF";
		ctx.shadowBlur = 250;
		ctx.shadowColor = "#cc0000";
		ctx.moveTo(0,520);
		ctx.lineTo(1520, 520);
		ctx.lineWidth = widthFlux;
		widthFlux++;
		ctx.stroke();
		ctx.closePath();
		if (widthFlux > 1 && widthFlux < 150)
		{
			window.setTimeout(widthAniG, 30);
		}
		
	}
	var widthAniS = function () 
	{
		ctx.clearRect(0, 0, c.width, c.height);
		ctx.beginPath();
		ctx.strokeStyle = "#FFFFFF";
		ctx.shadowBlur = 1000;
		ctx.shadowColor = "#ff1a1a";
		ctx.lineWidth = widthFlux2;
		widthFlux2--;
		ctx.moveTo(0, 520);
		ctx.lineTo(1520, 520);
		ctx.stroke();
		ctx.closePath();
		if (widthFlux2 < 170 && widthFlux2 >= 1)
		{
			window.setTimeout(widthAniS, 25)
		}
		else
		{
			ctx.clearRect(0, 0, c.width, c.height);
		}
		
	}
	lineAni();
	window.setTimeout(widthAniG, 2000);
	window.setTimeout(widthAniS, 4700);
}

introLine();








	











	

	
