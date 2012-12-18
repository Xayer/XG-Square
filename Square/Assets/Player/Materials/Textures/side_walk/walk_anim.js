var Walk : Texture2D[];
var framesPerSecond = 10.0;

function Update () {
    var index : int = Time.time * framesPerSecond;
    index = index % Walk.Length;
    renderer.material.mainTexture = Walk[index];
}