using Trademark2024.Shared.Enum;

namespace Trademark2024.Services
{

    public static class MarkTypeHelper
    {
        public static Trademark2024.Shared.Enum.MarkType? selectedMarkType = null;

        public static void SelectMarkType(Trademark2024.Shared.Enum.MarkType markType)
        {
            if (selectedMarkType == markType)
            {
                selectedMarkType = null;
            }
            else
            {
                selectedMarkType = markType;
            }
        }

        public static string GetButtonClass(Trademark2024.Shared.Enum.MarkType markType)
        {
            return selectedMarkType == markType ? "btn btn-dark" : "btn btn-light";
        }

        public static string GetMarkTypeImagePath(Trademark2024.Shared.Enum.MarkType markType)
        {
            if (markType == Trademark2024.Shared.Enum.MarkType.None)
            {
                return "";
            }

            string imageName = markType switch
            {
                Trademark2024.Shared.Enum.MarkType.Word => "tm-wm.png",
                Trademark2024.Shared.Enum.MarkType.Figurative => "tm-fm.png",
                Trademark2024.Shared.Enum.MarkType.FigurativeWithWord => "tm-fwm.png",
                Trademark2024.Shared.Enum.MarkType.ThreeD => "tm-dm.png",
                Trademark2024.Shared.Enum.MarkType.Collective => "tm-cm.png",
                _ => ""
            };

            return $"regisForm-img/{imageName}";
        }

        public static string GetMarkTypeAltText(Trademark2024.Shared.Enum.MarkType markType)
        {
            return markType == Trademark2024.Shared.Enum.MarkType.None ? "" : markType.ToString();
        }

        public static string GetMarkTypeTitle(Trademark2024.Shared.Enum.MarkType markType)
        {
            return markType switch
            {
                Trademark2024.Shared.Enum.MarkType.Word => "Word Mark",
                Trademark2024.Shared.Enum.MarkType.Figurative => "Figurative Mark",
                Trademark2024.Shared.Enum.MarkType.FigurativeWithWord => "Figurative with Word Mark",
                Trademark2024.Shared.Enum.MarkType.ThreeD => "3D Mark",
                Trademark2024.Shared.Enum.MarkType.Collective => "Collective Mark",
                _ => ""
            };
        }

        public static string GetMarkTypeDescription(Trademark2024.Shared.Enum.MarkType markType)
        {
            return markType switch
            {
                Trademark2024.Shared.Enum.MarkType.Word => "A word mark consists solely of words, letters, or numbers without any design elements.",
                Trademark2024.Shared.Enum.MarkType.Figurative => "A figurative mark includes designs, graphics, symbols, or images.",
                Trademark2024.Shared.Enum.MarkType.FigurativeWithWord => "A combination of figurative and word mark.",
                Trademark2024.Shared.Enum.MarkType.ThreeD => "A three-dimensional representation used as a trademark.",
                Trademark2024.Shared.Enum.MarkType.Collective => "A trademark owned by an organization used by its members to identify with a level of quality.",
                _ => ""
            };
        }
    }
}


