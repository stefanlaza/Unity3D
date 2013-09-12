﻿var pointB : Vector3;
var speed = 3.0;

function Start () {
    var pointA = transform.position;
    while (true) {
        yield MoveObject(transform, pointA, pointB, speed);
        yield MoveObject(transform, pointB, pointA, speed);
    }
}
 
function MoveObject (thisTransform : Transform, startPos : Vector3, endPos : Vector3, time : float) {
    var i = 0.0;
    var rate = 1.0/time;
    while (i < 1.0) {
        i += Time.deltaTime * rate;
        thisTransform.position = Vector3.Lerp(startPos, endPos, i);
        yield; 
    }
}