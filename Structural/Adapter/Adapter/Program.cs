using Adapter;

internal class Program
{
    private static void Main(string[] args)
    {
        RoundHole hole = new RoundHole(15);
        RoundStick rstick_small = new RoundStick(15);
        RoundStick rstick_large = new RoundStick(25);

        hole.fits(rstick_small);
        hole.fits(rstick_large);

        SquareStick sqstick_small = new SquareStick(15);
        SquareStick sqstick_large = new SquareStick(25);

        // hole.fits(sqstick); /* Cannot compile */

        SqaureToRoundStickAdapter sqstickAdapter = new SqaureToRoundStickAdapter(sqstick_small);
        hole.fits(sqstickAdapter);
        sqstickAdapter.changeAdaptee(sqstick_large);
        hole.fits(sqstickAdapter);
    }
}