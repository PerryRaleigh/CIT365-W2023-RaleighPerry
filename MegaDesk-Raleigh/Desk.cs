
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Raleigh
{
    public class Desk
    {
        public int width { get; set; }
        [Required]
        [Range(MINDEPTH, MAXDEPTH)]
        public int depth { get; set; }
        [Range(0,MAXDRAWERS)]
        public int drawers { get; set; }
        public string surfaceMaterial { get; set; }

        // Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MAXDRAWERS = 7;

        public Desk()
        {
            this.width= MINWIDTH;
            this.depth= MINDEPTH;
            this.drawers= 0;
            this.surfaceMaterial = DesktopMaterial.Pine.ToString();
        }

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public double DeskSize()
        {
            return width*depth;
        }
    }

    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
