extends CharacterBody2D

var speed = 2000
var dir : float
var pos : Vector2
var rot : float

func _ready():
	global_position=pos
	global_rotation=rot

func _physics_process(delta: float):
	velocity = Vector2(speed,0).rotated(dir)
	move_and_slide()
