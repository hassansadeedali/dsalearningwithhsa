using System.Collections.Generic;
using System.Linq;

namespace Blind75.Graphs
{
    /*
    There are a total of numCourses courses you have to take, 
    labeled from 0 to numCourses - 1. You are given an array 
    prerequisites where prerequisites[i] = [ai, bi] indicates 
    that you must take course bi first if you want to take course ai.
    
    For example, the pair [0, 1], indicates that to take 
    course 0 you have to first take course 1.

    Return true if you can finish all courses. Otherwise, return false.
     */
    public class CourseSchedule
    {
        public static int numCourses = 2;
        public static int[][] prerequisites = { new int[] { 1, 0 } };

        //public static int[][] prerequisites = { new int[] { 1, 0 }, new int[] { 0, 1 } };
        public static bool Handle()
        {
            var preMap = new Dictionary<int,List<int>>();
            var visited = new HashSet<int>();

            foreach (var course in prerequisites)
            {
                //Course to Take - course[0]
                //Course Prereq - course[1]

                if (preMap[course[0]] == null)
                {
                    var list = new List<int>();
                    list.Add(course[1]);
                    preMap[course[0]] = list;
                }
                else
                {
                    preMap[course[0]].Add(course[1]);
                }
            }

            foreach (int c in Enumerable.Range(0, numCourses))
            {
                if (!DFS(c, visited,preMap))
                    return false;
            }
            return true;
        }

        private static bool DFS(int course, HashSet<int> visited, Dictionary<int, List<int>> preMap)
        {
            if (visited.Contains(course))
                return false;

            if (preMap[course].Count == 0)
                return true;

            visited.Add(course);

            foreach (var pre in preMap[course])
            {
                if (!DFS(pre, visited, preMap))
                    return false;
            }

            visited.Remove(course);
            preMap[course].Clear();

            return true;
        }
    }
}
