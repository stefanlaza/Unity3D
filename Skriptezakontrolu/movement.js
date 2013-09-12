var speed : float = 10.0;
var jumpSpeed : float = 10.0;
function Update ()
{
var translation : float = Input.GetAxis("Horizontal") * speed;
var jumping : float = Input.GetAxis("Vertical") * jumpSpeed;
translation *=Time.deltaTime;
jumping *=Time.deltaTime;
transform.Translate(translation,0,0);
transform.Translate(0,jumping,0);
}