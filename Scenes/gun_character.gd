extends CharacterBody2D
var bullet_path = preload("res://Scenes/bullet.tscn")

func _physics_process(delta):
	look_at(get_global_mouse_position())
	if Input.is_action_just_pressed("left_click"):
		fire()

func fire():
	var bullet = bullet_path.instantiate()
	
	# Assign correct properties
	bullet.rot = global_rotation  # If bullet needs direction
	bullet.pos = $Node2D.global_position  # Ensure correct spawn position
	bullet.dir = rotation

	# Add bullet to the scene
	get_parent().add_child(bullet)
