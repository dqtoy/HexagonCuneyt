using System;

/// <summary>
/// Please do not remove EDITOR comments in the file. 
/// They used to edit script within editor while creating screens 
////////// </summary>
namespace Assets.Scripts.Core.Enums
{
    [Flags]
    public enum GameStatus
    {
        Blocked = 1 << 0,
        Confirm = 1 << 1,
        Home = 1 << 2,

        GameIsPlaying = 1 << 3,
        HexIsRotating = 1 << 4,
        SelectedHexes = 1 << 5,
        MatchAnimation = 1 << 6,
        //Pages = Page1 | Page2 | Page3,

        /*EDITOR-BREAKPOINT*/

        All = ~(-1 << 7/*EDITOR-NUMPOINT*/),
    }

}