extends CharacterBody2D

@export var movement_speed: float = 500.0
var direction: Vector2


func _physics_process(delta: float) -> void:
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
