using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-ways-to-build-rooms-in-an-ant-colony/
    /// </summary>
    public class Leetcode_1916_CountWaysToBuildRoomsInAntColony_V1
    {
        public int CountNumberOfWays(int[] prevRoom)
        {
            var roomLookup = ConstructLookup(prevRoom);
            return 1;
        }

        private IDictionary<int, Room> ConstructLookup(int[] prevRooms)
        {
            var lookup = new Dictionary<int, Room>();
            lookup.Add(0, new Room(0));
            for (var room = 1; room < prevRooms.Length; room++)
            {
                if (!lookup.ContainsKey(room))
                {
                    lookup.Add(room, new Room(room));
                }

                var currentRoom = lookup[room];
                var previousRoom = prevRooms[room];
                if (!lookup.ContainsKey(previousRoom))
                {
                    lookup.Add(previousRoom, new Room(previousRoom));
                }
                lookup[previousRoom].NextRooms.Add(currentRoom);
            }
            return lookup;
        }

        internal class Room
        {
            internal Room(int id)
            {
                Id = id;
            }
            internal int Id { get; set; }
            internal IList<Room> NextRooms { get; set; } = new List<Room>();
        }
    }
}
