var c=document.getElementById("intro");
var ctx=c.getContext("2d");
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
window.setTimeout(titleAni, 4700);
window.setTimeout(titleAni, 4800);
window.setTimeout(titleAni, 5000);
window.setTimeout(titleAni, 5200);
window.setTimeout(titleAni, 6200);
window.setTimeout(titleAni, 6700);
window.setTimeout(titleAni, 6900);
window.setTimeout(titleAni, 7400);
window.setTimeout(titleAni, 7700);
window.setTimeout(titleAni, 7900);
window.setTimeout(titleAni, 8000);
window.setTimeout(titleAni, 8100);
window.setTimeout(titleAni, 8150);
window.setTimeout(titleAni, 8200);
window.setTimeout(titleAni, 8300);
window.setTimeout(titleAni, 8400);

var glow = 1;

var titleGlowup = function()
{
	ctx.clearRect(0, 0, c.width, c.height);
	ctx.beginPath();
	ctx.shadowBlur = 35;
	ctx.lineWidth = glow;
	ctx.strokeStyle = "#000000";
	ctx.moveTo(0,520);
	ctx.lineTo(1520, 520);
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
	ctx.lineTo(1520, 520);
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
window.setTimeout(titleGlowup, 10000);
