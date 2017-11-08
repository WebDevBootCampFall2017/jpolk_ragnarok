var c=document.getElementById("intro");
var ctx=c.getContext("2d");
c.width = window.innerWidth;
c.height = window.innerHeight;
var canWidth = c.width
var canHeight = c.height

var titleAni = function()
{
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowBlur = 0;
	ctx.font = "300px Impact";
	var gradient = ctx.createLinearGradient(0, 0, c.width, 0)
	gradient.addColorStop("0.2", "#4d0000");
	gradient.addColorStop("0.4", "white");
	gradient.addColorStop("0.6", "black");
	gradient.addColorStop("0.65", "white");
	gradient.addColorStop(".87", "#4d0000");
	ctx.fillStyle = gradient;
	ctx.fillText("RAGNAROK", 100, 520)
	ctx.stroke();
}
window.setTimeout(titleAni, 6700);
window.setTimeout(titleAni, 6800);
window.setTimeout(titleAni, 7000);
window.setTimeout(titleAni, 7200);
window.setTimeout(titleAni, 8200);
window.setTimeout(titleAni, 8700);
window.setTimeout(titleAni, 8900);
window.setTimeout(titleAni, 9400);
window.setTimeout(titleAni, 9700);
window.setTimeout(titleAni, 9900);
window.setTimeout(titleAni, 10000);
window.setTimeout(titleAni, 10100);
window.setTimeout(titleAni, 10150);
window.setTimeout(titleAni, 10200);
window.setTimeout(titleAni, 10300);
window.setTimeout(titleAni, 10400);

var glow = 1;

var titleGlowup = function()
{
	ctx.clearRect(0, 0, c.width, c.height);
	ctx.beginPath();
	ctx.shadowBlur = 35;
	ctx.lineWidth = glow;
	ctx.strokeStyle = "#000000";
	ctx.moveTo(0,520);
	ctx.lineTo(canWidth, 520);
	ctx.stroke();
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowBlur = 0;
	ctx.lineWidth = 1;
	ctx.rect(120, 420, 1220, 100);
	ctx.fillStyle = "#000000";
	ctx.fill();
	ctx.stroke();
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowColor = "#cc0000";
	ctx.shadowBlur = glow;
	ctx.font = "300px Impact";
	var gradient = ctx.createLinearGradient(0, 0, c.width, 0)
	gradient.addColorStop("0.2", "#4d0000");
	gradient.addColorStop("0.4", "white");
	gradient.addColorStop("0.6", "black");
	gradient.addColorStop("0.65", "white");
	gradient.addColorStop(".87", "#4d0000");
	ctx.fillStyle = gradient;
	ctx.fillText("RAGNAROK", 100, 520)
	ctx.stroke();
	glow++;
	if(glow >= 100)
	{
		window.setTimeout(titleGlowdown, 35)
	}
	else
	{
		window.setTimeout(titleGlowup, 35)
	}
}

var titleGlowdown = function()
{
	ctx.clearRect(0, 0, c.width, c.height);
	ctx.beginPath();
	ctx.lineWidth = glow;
	ctx.shadowColor = "#ff1a1a";
	ctx.moveTo(0,520);
	ctx.lineTo(canWidth, 520);
	ctx.stroke();
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowBlur = 0;
	ctx.lineWidth = 1;
	ctx.rect(120, 420, 1220, 100);
	ctx.fillStyle = "#000000";
	ctx.fill();
	ctx.stroke();
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowBlur = glow;
	ctx.font = "300px Impact";
	var gradient = ctx.createLinearGradient(0, 0, c.width, 0)
	gradient.addColorStop("0.2", "#4d0000");
	gradient.addColorStop("0.4", "white");
	gradient.addColorStop("0.6", "black");
	gradient.addColorStop("0.65", "white");
	gradient.addColorStop(".87", "#4d0000");
	ctx.fillStyle = gradient;
	ctx.fillText("RAGNAROK", 100, 520)
	ctx.stroke();
	glow--;
	if (glow <= 1)
	{
		window.setTimeout(titleGlowup, 35)
	}
	else
	{
		window.setTimeout(titleGlowdown, 35)
	}
}
window.setTimeout(titleGlowup, 12000);

var clearCanvas = function()
{
	ctx.clearRect(0, 0, c.width, c.height);
}
