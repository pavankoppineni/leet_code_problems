using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-fuel-cost-to-report-to-the-capital/
    /// </summary>
    public class Leetcode_2477_MinimumFuelCostToReportToCapital_V1
    {
        private HashSet<int> _visited;
        private IDictionary<int, ISet<int>> _adjacencyList;
        private int _seats;
        public long CalculateMinimumFuelRequired(int[][] roads, int seats)
        {
            if (roads.Length == 0)
            {
                return 0;
            }

            _adjacencyList = CreateAdjacencyList(roads);
            _visited = new HashSet<int>();
            _seats = seats;
            var result = CalculateMinimumFuelRequired(0);
            return result.FuelRequired;
        }

        private Result CalculateMinimumFuelRequired(int city)
        {
            //When : City is visited
            //Then : Return EMPTY
            if (_visited.Contains(city))
            {
                return Result.EMPTY;
            }
            _visited.Add(city);
            var result = new Result();
            foreach (var road in _adjacencyList[city])
            {
                var currentResult = CalculateMinimumFuelRequired(road);
                result.Add(currentResult);
            }
            result.AdjustVehicles(_seats, 1);
            return result;
        }

        private IDictionary<int, ISet<int>> CreateAdjacencyList(int[][] roads)
        {
            var adjacencyList = new Dictionary<int, ISet<int>>();
            foreach (var road in roads)
            {
                var source = road[0];
                var target = road[1];
                if (!adjacencyList.ContainsKey(source))
                {
                    adjacencyList.Add(source, new HashSet<int>());
                }
                if (!adjacencyList.ContainsKey(target))
                {
                    adjacencyList.Add(target, new HashSet<int>());
                }
                adjacencyList[source].Add(target);
                adjacencyList[target].Add(source);
            }
            return adjacencyList;
        }
    }

    public class Result
    {
        public static Result EMPTY = new Result();
        public long PeopleCount { get; set; }
        public long VehicleCount { get; set; }
        public long FuelRequired { get; set; }
        public void Add(Result result)
        {
            PeopleCount += result.PeopleCount;
            VehicleCount += result.VehicleCount;
            FuelRequired += result.FuelRequired + result.VehicleCount;
        }
        
        public void AdjustVehicles(int seats, int newPeople)
        {
            PeopleCount += newPeople;
            var totalSeats = VehicleCount * seats;

            //When : people count is greater than total seats
            //Then : Add new vehicle
            if (PeopleCount > totalSeats)
            {
                VehicleCount += 1;
                return;
            }

            //When : people count is less than total seats
            //THen : Adjust vehicles
            var requiredVehicles = PeopleCount / seats;
            if (PeopleCount % seats == 0)
            {
                VehicleCount = requiredVehicles;
            }
            else
            {
                VehicleCount = requiredVehicles + 1;
            }
        }
    }
}
