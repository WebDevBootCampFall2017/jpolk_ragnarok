var c=document.getElementById("intro");
var ctx=c.getContext("2d");
var titleAni = function()
{
	ctx.closePath();
	ctx.beginPath();
	ctx.shadowBlur = 1;
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
window.setTimeout(titleAni, 8320);


