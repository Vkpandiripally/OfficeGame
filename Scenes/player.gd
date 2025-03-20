extends CharacterBody2D

@onready var pivot = $pivot

@export var radius = 30
@export var movement_speed: float = 500.0
var direction: Vector2


func _physics_process(delta: float) -> void:
	# rotate gun around player
	#pivot.look_at(get_global_mouse_position())
	#
	## keep gun at fixed radius
	#pivot.position = Vector2.RIGHT.rotated(pivot.rotation)
	
	direction.x = Input.get_axis("left", "right")
	direction.y = Input.get_axis("up", "down")
	direction = direction.normalized()
	
	# flip character
	#if direction.x > 0: %sprite.flip_h = false
	#elif direction.y < 0: %sprite.flip_h = true
	
	if direction:
		velocity = direction * movement_speed
		#if %sprite.animation != "Walking": %sprite.animation = "Walking"
	else:
		velocity = velocity.move_toward(Vector2.ZERO, movement_speed)
		#if %sprite.animation != "Idle": %sprite.animation = "Idle"

	move_and_slide()
