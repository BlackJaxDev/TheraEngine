using TheraEditor.Properties;
using TheraEditor.Windows.Forms;
using TheraEngine.Animation;

namespace TheraEditor.Wrappers
{
    [NodeWrapper(nameof(Resources.GenericFile), nameof(Resources.GenericFile))]
    public class PropAnimFloatWrapper : FileEditorWrapperBase<PropAnimFloat, DockablePropAnimFloatGraph> { }
}
