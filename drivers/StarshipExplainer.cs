using Godot;

namespace StarshipExplainer.drivers;

public partial class StarshipExplainer : Node2D {
	public InputDriver InputDriver;
	public ExplainerDriver ExplainerDriver;
	public StarshipExplainer() {
		InputDriver = new InputDriver(this);
		ExplainerDriver = new ExplainerDriver(this);
	}

	public override void _Ready() {
		AddChild(InputDriver);
		AddChild(ExplainerDriver);
	}
}