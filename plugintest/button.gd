extends Button
var rate = 0

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass


func _on_button_down() -> void:
	$caller.Say("One two three four five six seven eight nine ten eleven twelve")
	rate += 1
	$caller.Set_rate(rate)
	pass # Replace with function body.
