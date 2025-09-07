using Godot;

namespace StarshipExplainer.drivers;

public partial class CameraDriver(StarshipExplainer sx) : Camera2D {
	public override void _Ready() {
		SetPosition(new Vector2(710,-420));
		SetZoom(new Vector2(1.085f,1.085f));
	}
}