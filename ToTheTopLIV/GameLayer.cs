namespace ToTheTopLIV
{
	public enum GameLayer
	{
        Default = 0,
        TransparentFX = 1,
        PlayerBody = 11,
        PlayerHand = 12, //Oddly not the whole right hand
        BuddyBot = 13,
        RenderProxy = 21,//Mask

        // Custom layers to use in the mod.
        LivOnly = 31
    }
}