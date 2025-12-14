/*
    1. The game is too easy, powerups are so frequent that it's trivial to keep the time up.
    2. Slightly reducing the frequency of powerups and possible varying the size of obstacles could make for a more challenging and engaging experience.
    3. I would like some visual effects when  collecting powerups.
    4. It's fun precicely weaving between obstacles to collect powerups.
    5. It currently lacks and variety or challeng, making the whole thing somewhat monotenous.

    
    * Moved the PhaseIn method to before Update because it wasn't functional in the spot the book said to put it(probably user error somehow, but it works now)
    * Altered the obstacle to be a sawblade trap(rusted metal texture https://www.google.com/url?sa=t&source=web&rct=j&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Drust%2Bmetal&ved=0CBUQjRxqFwoTCLCDzbLsvZEDFQAAAAAdAAAAABAf&opi=89978449)
    * Changed the powerup tp a cube and changed the particle system to be lika a spotlight on the cube
    * Lowered the frequency of powerups from 1/2 to 1/4
    * Added random variance in object size
 
 */