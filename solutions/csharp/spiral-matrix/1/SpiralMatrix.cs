public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        
        int [,] matrix = new int[size,size];

        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;
        
        int value = 1;
        int maxValues = size * size;

        while (value <= maxValues)
        {
            // 1. Move Right along the top row
            for (int i = left; i <= right && value <= maxValues; i++)
            {
                matrix[top, i] = value++;
            }
            top++; // Shrink the top boundary down

            // 2. Move Down along the right column
            for (int i = top; i <= bottom && value <= maxValues; i++)
            {
                matrix[i, right] = value++;
            }
            right--; // Shrink the right boundary left

            // 3. Move Left along the bottom row
            for (int i = right; i >= left && value <= maxValues; i--)
            {
                matrix[bottom, i] = value++;
            }
            bottom--; // Shrink the bottom boundary up

            // 4. Move Up along the left column
            for (int i = bottom; i >= top && value <= maxValues; i--)
            {
                matrix[i, left] = value++;
            }
            left++; // Shrink the left boundary right
        }

        return matrix;
    }
}
