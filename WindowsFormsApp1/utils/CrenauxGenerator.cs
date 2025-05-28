using System;
using System.Collections.Generic;
using System.Linq;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Utils
{
    public static class CreneauxGenerator
    {
        public static List<SelectListViewModel> GenerateCreneaux(
            string heureDebut,
            string heureFin,
            int creneauMinutes,
            List<string> bookedHeures)
        {
            var creneauxList = new List<SelectListViewModel>();

            DateTime startTime = DateTime.Parse(heureDebut);
            DateTime endTime = DateTime.Parse(heureFin);

            while (startTime.AddMinutes(creneauMinutes) <= endTime)
            {
                DateTime endSlot = startTime.AddMinutes(creneauMinutes);
                string formattedSlot = $"{startTime:HH:mm} - {endSlot:HH:mm}";
                string slotStartTime = startTime.ToString("HH:mm");

                if (!bookedHeures.Contains(slotStartTime))
                {
                    creneauxList.Add(new SelectListViewModel
                    {
                        Text = formattedSlot,
                        Value = slotStartTime
                    });
                }

                startTime = endSlot;
            }

            return creneauxList;
        }
    }
}
