namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sequence
    {
        public static List<int> LongestSubsequence(List<int> items)
        {
            var result = new List<int>();
            var currentSequenceLength = 1;
            var bestSequenceLength = 1;
            var currentElement = items[0];
            var elementFromBestSeqence = 0;

            for (int i = 1; i < items.Count; i++)
            {
                if(items[i] == currentElement)
                {
                    currentSequenceLength++;
                }
                else
                {
                    if(currentSequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentSequenceLength;
                        currentSequenceLength = 1;
                        elementFromBestSeqence = items[i - 1];
                    }

                    currentElement = items[i];
                }
            }

            for (int i = 0; i < bestSequenceLength; i++)
            {
                result.Add(elementFromBestSeqence);
            }

            return result;
        }
        
        public static List<int> RemoveNegativeNumbers(List<int> items)
        {
            return items
                .Select(x => x)
                .Where(x => x > 0)
                .ToList();
        }
        
        public static List<int> RemoveOddNumberOfTimeOccurence(List<int> items)
        {
            var sortedList = new List<int>();

            foreach (var item in items)
            {
                sortedList.Add(item);
            }

            sortedList.Sort();

            var currentNumberOccurence = 1;
            var currentElement = sortedList[0];
            var numbersToDelete = new List<int>();

            for (int i = 1; i < sortedList.Count; i++)
            {
                if(sortedList[i] == currentElement)
                {
                    currentNumberOccurence++;
                }
                else
                {
                    if(currentNumberOccurence % 2 != 0)
                    {
                        numbersToDelete.Add(currentElement);
                    }

                    currentNumberOccurence = 1;
                    currentElement = sortedList[i];
                }
            }

            for (int i = 0; i < numbersToDelete.Count; i++)
            {
                items.RemoveAll(x => x == numbersToDelete[i]);
            }

            return items;
        }
        
        public static List<KeyValuePair <int, int>> CountEachElementOccurence(List<int> items)
        {
            items.Sort();

            var countedNumbers = new List<KeyValuePair<int, int>>();
            var currentValueCounter = 1;
            var currentValueFromList = items[0];
            var currentKey = 0;
            var currentValue = 0;

            for (int i = 1; i < items.Count; i++)
            {
                if(items[i] == currentValueFromList)
                {
                    currentValueCounter++;
                }
                else
                {
                    currentKey = currentValueFromList;
                    currentValue = currentValueCounter;

                    countedNumbers.Add(new KeyValuePair<int, int>(currentKey, currentValue));

                    currentValueFromList = items[i];
                    currentValueCounter = 1;
                }

                if(i == (items.Count - 1))
                {
                    currentKey = currentValueFromList;
                    currentValue = currentValueCounter;

                    countedNumbers.Add(new KeyValuePair<int, int>(currentKey, currentValue));
                }
            }

            return countedNumbers;
        }
        
        public static List<int> MajorantOfAnArray(List<int> items)
        {
            var majorantsList = new List<int>();

            items.Sort();

            var currentValueCounter = 1;
            var currentValue = items[0];
            
            for (int i = 1; i < items.Count; i++)
            {
                if(items[i] == currentValue)
                {
                    currentValueCounter++;
                }
                else
                {
                    if(currentValueCounter >= (items.Count/2 + 1))
                    {
                        majorantsList.Add(currentValue);
                    }

                    currentValueCounter = 1;
                    currentValue = items[i];
                }
            }

            return majorantsList;
        }

        public static Queue<int> SequenceForGivenN(int start, int targetSequenceLength)
        {
            Queue<int> container = new Queue<int>();
            container.Enqueue(start);
            var result = new Queue<int>();

            while (result.Count < targetSequenceLength)
            {
                int currentBase = container.Dequeue();
                result.Enqueue(currentBase);
                container.Enqueue(currentBase + 1);
                container.Enqueue(2 * currentBase + 1);
                container.Enqueue(currentBase + 2);
            }

            return result;
        }

        public static void PrintShortestSequence(int start, int target)
        {
            if (start < 0 || start >= target)
            {
                Console.WriteLine("Start should be >= 0 and smaller than the target!");
                return;
            }

            var sequence = new Queue<int>();
            sequence.Enqueue(start);

            if (start + 1 == target)
            {
                sequence.Enqueue(start + 1);
                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            if (start + 2 == target)
            {
                sequence.Enqueue(start + 2);
                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            if (start + 2 > start * 2)
            {
                start += 2;
                sequence.Enqueue(start);
            }

            if (start * 2 > target)
            {
                while (start + 2 <= target)
                {
                    sequence.Enqueue(start += 2);
                }

                if (start != target)
                {
                    sequence.Enqueue(start += 1);
                }

                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            while (start * 2 < target / 2)
            {
                sequence.Enqueue(start *= 2);
            }

            while (start + 2 <= target / 2)
            {
                sequence.Enqueue(start += 2);
            }

            while (start + 1 <= target / 2)
            {
                sequence.Enqueue(start += 1);
            }

            sequence.Enqueue(start *= 2);

            if (start != target)
            {
                sequence.Enqueue(start += 1);
            }

            Console.WriteLine(string.Join(" --> ", sequence));
        }
    }
}
