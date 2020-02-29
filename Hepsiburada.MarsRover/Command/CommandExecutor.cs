using System.Collections.Generic;
using Hepsiburada.MarsRover.Enums;
using Hepsiburada.MarsRover.Rovers;

namespace Hepsiburada.MarsRover.Commands
{
    public class CommandExecutor : ICommandExecutor
    {
        private Dictionary<DirectionEnum, DirectionEnum> LeftTurnDictionary;
        private Dictionary<DirectionEnum, DirectionEnum> RightTurnDictionary;

        public CommandExecutor()
        {
            LeftTurnDictionary = new Dictionary<DirectionEnum, DirectionEnum>()
            {
                { DirectionEnum.East, DirectionEnum.North },
                { DirectionEnum.North, DirectionEnum.West },
                { DirectionEnum.West, DirectionEnum.South },
                { DirectionEnum.South, DirectionEnum.East }

            };

            RightTurnDictionary = new Dictionary<DirectionEnum, DirectionEnum>()
            {
                { DirectionEnum.East, DirectionEnum.South },
                { DirectionEnum.South, DirectionEnum.West },
                { DirectionEnum.West, DirectionEnum.North },
                { DirectionEnum.North, DirectionEnum.East }

            };
        }

        public void Execute(IRover rover, ICommand command)
        {
            if (command.GetCommandType() == CommandTypeEnum.Move)
            {
                MoveForward(rover);
                return;
            }

            ChangeDirection(rover, command);
        }

        private void ChangeDirection(IRover rover, ICommand command)
        {
            if(command.GetCommandType() == CommandTypeEnum.Left)
            {
                rover.Face.CurrentFace = LeftTurnDictionary[rover.Face.CurrentFace];
                return;
            }

            rover.Face.CurrentFace = RightTurnDictionary[rover.Face.CurrentFace];
        }

        private void MoveForward(IRover rover)
        {
            if (rover.Face.CurrentFace == DirectionEnum.East)
            {
                rover.Position.X++;
                return;
            }
            if (rover.Face.CurrentFace == DirectionEnum.West)
            {
                rover.Position.X--;
                return;
            }
            if (rover.Face.CurrentFace == DirectionEnum.North)
            {
                rover.Position.Y++;
                return;
            }
            if (rover.Face.CurrentFace == DirectionEnum.South)
            {
                rover.Position.Y--;
                return;
            }
        }
    }
}
