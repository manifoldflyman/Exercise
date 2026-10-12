class Lasagna
{
    const int expectedMinutesInOven = 40;

    public int ExpectedMinutesInOven() {
        return expectedMinutesInOven;
    }
    
    public int RemainingMinutesInOven(int m)
    {
        int r = 0;
        if (m > 40)
            r = 0;
        else if (m < 0)
            r = 0;
        else if (m <= 40)
            r = expectedMinutesInOven - m;
        return r;
    }
    
    public int PreparationTimeInMinutes(int l)
    {
        return (l < 0) ? 0 : l*2;
    }
    
    public int ElapsedTimeInMinutes(int l, int m) {
        return 2*l + m;
    }
}
