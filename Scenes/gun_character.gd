extends CharacterBody2D
var bullet_path = preload("res://Scenes/bullet.tscn")
@onready var pivot: Node2D = $pivot

func _physics_process(delta):
	look_at(get_global_mouse_position())
	if Input.is_action_just_pressed("left_click"):
		fire()

func fire():
	var bullet = bullet_path.instantiate()
	
	## Ensure correct spawn position (at the gun's position)
	#bullet.global_position = $Node2D.global_position  
	#
	## Use the gun's rotation to define the shooting direction
	#bullet.rotation = $Node2D.rotation  # Set bullet rotation based on gun's rotation
	#
	## Set the bullet's movement direction to shoot straight from the gun
	#bullet.direction = Vector2.RIGHT.rotated(bullet.rotation)  # Use gun's rotation
	
	bullet.dir = rotation
	bullet.pos = $Node2D.global_position
	bullet.rot = global_rotation
	
	# Add bullet to the scene
	get_parent().add_child(bullet)
