using Godot;

namespace StarshipExplainer.drivers;

public partial class ExplainerDriver(StarshipExplainer sx) : Node {
	private CameraDriver _cameraDriver = new(sx);

	private Sprite2D _starship = new() {
		Texture = (Texture2D)GD.Load("res://sprites/starship.png")
	};
	
	public override void _Ready() {
		AddChild(_cameraDriver);
	}
}