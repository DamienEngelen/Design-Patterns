using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Demo: set up commands and test Undo ---
            RemoteControl remoteControl = new RemoteControl();

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(livingRoomLight);
            Stereo stereo = new Stereo();

            // Configure slots
            remoteControl.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(2, new CeilingFanHighCommand(livingRoomCeilingFan), new CeilingFanOffCommand(livingRoomCeilingFan));
            remoteControl.SetCommand(3, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(4, new StereoOnWithCdCommand(stereo), new StereoOffCommand(stereo));

            Console.WriteLine(remoteControl);

            // Light slot 0 ON, then Undo
            Console.WriteLine("--- Press slot 0 ON ---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("--- Press Undo ---");
            remoteControl.UndoButtonWasPushed();

            // Light slot 0 OFF, then Undo
            Console.WriteLine("--- Press slot 0 OFF ---");
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine("--- Press Undo ---");
            remoteControl.UndoButtonWasPushed();

            // Ceiling fan HIGH and Undo
            Console.WriteLine("--- Press slot 2 ON (CeilingFan HIGH) ---");
            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine("--- Press Undo (should restore previous speed) ---");
            remoteControl.UndoButtonWasPushed();

            // Stereo ON with CD and Undo
            Console.WriteLine("--- Press slot 4 ON (Stereo CD) ---");
            remoteControl.OnButtonWasPushed(4);
            Console.WriteLine("--- Press Undo (Stereo Off) ---");
            remoteControl.UndoButtonWasPushed();


        }
    }
}