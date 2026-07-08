// auto-generated

using System.Runtime.InteropServices;
using Sweet.Intents.Actions;
using Sweet.Intents.Axes;
using Silk.NET.GLFW;

namespace Sweet.Intents.Generated;

/// <summary>
///     this code was automatically generated from the .intents sourse file
/// </summary>
public unsafe class EditorCameraIntents : IDisposable
{
    public static ActionState* Sprint { get; private set; }
    public static ActionState* Move { get; private set; }

    public static AxisState* MoveForward { get; private set; }
    public static AxisState* MoveRight { get; private set; }
    public static AxisState* MoveUp { get; private set; }

    internal static void Build(ref IntentBuilder builder)
    {
        // Acion states
        Sprint = (ActionState*)NativeMemory.Alloc((nuint)sizeof(ActionState));
        *Sprint = new ActionState(2); // value changing from .intents file

        Sprint->Clauses.Add(new Clause(1)); // 0
        Sprint->Clauses.Add(new Clause(1)); // 1

        builder.Bind(Keys.ShiftLeft, Sprint, 0);

        builder.Bind(Keys.W, Sprint, 1);
        builder.Bind(Keys.A, Sprint, 1);
        builder.Bind(Keys.S, Sprint, 1);
        builder.Bind(Keys.D, Sprint, 1);

        Move = (ActionState*)NativeMemory.Alloc((nuint)sizeof(ActionState));
        *Move = new ActionState(1); // value changing from .intents file

        Move->Clauses.Add(new Clause(1)); // 0

        builder.Bind(Keys.W, Move, 0);
        builder.Bind(Keys.A, Move, 0);
        builder.Bind(Keys.S, Move, 0);
        builder.Bind(Keys.D, Move, 0);

        // Axis states
        MoveForward = (AxisState*)NativeMemory.Alloc((nuint)sizeof(AxisState));
        *MoveForward = new AxisState();

        MoveRight = (AxisState*)NativeMemory.Alloc((nuint)sizeof(AxisState));
        *MoveRight = new AxisState();

        MoveUp = (AxisState*)NativeMemory.Alloc((nuint)sizeof(AxisState));
        *MoveUp = new AxisState();

        builder.KickBack += KickBack;
    }

    private static void KickBack()
    {

    }

    public void Dispose()
    {
        if (Sprint != null)
        {
            Sprint->Dispose();
            NativeMemory.Free(Sprint);

            Sprint = null;
        }

        if (Move != null)
        {
            Move->Dispose();
            NativeMemory.Free(Move);

            Move = null;
        }


        if (MoveForward != null)
        {
            NativeMemory.Free(MoveForward);

            MoveForward = null;
        }

        if (MoveRight != null)
        {
            NativeMemory.Free(MoveRight);

            MoveRight = null;
        }

        if (MoveUp != null)
        {
            NativeMemory.Free(MoveUp);

            MoveUp = null;
        }
    }
}