# You can place the script of your game in this file.

# Declare images below this line, using the image statement.
# eg. image eileen happy = "eileen_happy.png"

# Declare characters used by this game.
define d = Character('Dev | Da_NKP', color="#c8ffc8")
define p = Character('Maya', color="#99FF66")
define l = Character('Leon', color="#FF0000")
define s = Character('Sasha', color="#FFFFFF")
define j = Character('John', color="#c8ffc8")


# The game starts here.
label start:
    
    d "This is the First Stage in the Agile Development of Apples and Oranges, ANO for short. (Working title)."
    
    d "The purpose of this stage is to create the story, as well as the game plot."
    
    d "Given that Choice-script is not built for this kind of game, "
    
    d "some of the elements (such as longer narrative and story) can become tiresome."
    
    d "The first step will be completed when the story and plot are completely developed, "
    
    d "as well as game influence, and when there is feasibility in moving to the next stage and game engine."
    
    d "(Hint: this is the second stage and game engine)"
    
    d "This was Alpha-Build .03, but that was for Choice-script..."

    d "...and this is Ren-Py, so..."
    
    d "Without further ado, I hereby declare this Alpha-Build .01RP!"
    
    d "Well, now that there's an actual intro scene, I guess it's actually Alpha-Build .02RP...meh."
    
    d "I should warn you that what follows is unstable, incomplete, and extremely dangerous."
    
    d "Well then, would you like to proceed?"
    
    menu:
        "Oh Yeah!":
            "In that case, let's begin!"
            jump intro
        "Eh...perhaps not...":
            jump badend


label badend:
    d "Well, that's OK. I hope you enjoy ANO when it's done!"

    jump end
    
label intro:

#This can be handled in alternating First Person

    "Unknown" "Hey, John! Wait up!"
    
    "The weekend, finally, was here. I was looking forward to this, but I can never seem to get out of this place fast enough..."
    
    j "Oh, hi Sasha."
    
    "Gotta get out of here; she's not going to make this easy..."
    
    s "Do you want to go to the party with me?"
    
    s "Our entire class is going and there will be food and games and music and even a movie! It's going to be an 'epic' party!"
    
    "My fears have been confirmed."
    
    "I really want to go, especially with Sasha. Spending time with classmates would be great! But going with her? I would love to, but what would my classmates think? What would she think if I responded too quickly? Worse still, what would the whole school think?"
    
    "What would I say? How would I say it? And why me - why did Sasha ask me?"
    
    "But really, I do not know her that well, and I know she could not possibly know me that well. But what if she thought she knew me? Or am I just over-thinking this?"
    
    s "Uh...John," 
    
    s "...are you coming?"
    
    "Oh no! It has been nearly three minutes! Or was it five? Hmm... I am impressed that Sasha waited that long for an answer, though. Forget that! I have to give her an answer. She cannot notice this, not now. I can feel my pulse, which means that she can probably tell that something is wrong. She was standing far too close to me; she had to have noticed! I have to answer! NOW!"
    
    s "Hey, are you oka—"
    
    j "I can't go with you!" #More cry than shout, but still some shout
    
    s ""
    j "" #stunned silence
    
    "Ahh!!! That could have not been a worse response! How is Sasha going to take that? What if she takes it personally? I can't possibly go now. If I did, and I ran into her at the party, what would I say? Would she even ask?"
    
    j "I'm sorry...but I just can't do this!"
#perspective change to Sasha    
    s "Uh..."
    
    "And he just ran off...that was...I don't know. Whatever that was, there's at least a couple other students who could hear that last bit."
    
    "Well, I'm fairly sure he's not coming...he looked...embarrased? I don't know. Still, there's a party that I have to get ready for."
    
    s "Party, here I come!"

label title:
    "ANO: Apples and Oranges"

label actone:

#Don't forget about Perspective. Even if a character isn't speaking, their thoughts are in first person. Maybe even throw in a thoughtful image or two.
    "Act One"

    p "The first day of school...well, not really the first day, since this day was more like day camp than school."

    "Now that I'm a Sophomore, I now know everyone here. Even better, now that I'm not a lowly Freshman anymore, everyone knows me." 

    "Especially Leon, who was arguably the most popular Senior in the school. He's the top of his class, excelling in Biology, Chemistry, Computer Science, Mathematics, and History." 

    p "Of course, academics were not the only things he 'excelled' at, so to speak."
    
    "Tom and Frank were normal enough, typical Seniors. Sam and Joe were athletes - the Jocks. Philip was the band guy, the Trumpet his weapon of choice."

    "All the other Seniors were similar enough to not stick out, that is, as much as Seniors could not stick out."

    p "That is...all but John..."

    "Yes, he did do well enough to not be noticed in class, and he was involved just enough to not be noticed, like some of his classmates."

    p "Something about him is just...wrong...I can't think of any other way to describe it."

    p "Maybe he's just awkward? But..."

    "John was never 'awkward' by himself, but it was mostly when he was with his classmates that he seemed different, especially with Leon."
#Should throw in some kind of background change here and maybe a softer transition
    "Weeks passed" #This transition still sucks...maybe this is where art assets should help..? Still though...
#Yeah, definately. This is a harsh transition
    p "John, John, John...screw it."
#That should make the transition MUCH better!
    p "This is far more interesting than Geometry, to say nothing about importance!"

    "While my teacher practices her Ben Stein impression, I've got much better things to do..."

    p "Besides, nobody cares that much about my grades, anyway. And it's not like I'm failing anything..."

    p "But what's with John?"

    p "I need some kind of strategy here..."

    "Aha! Finally, a fool-proof plan of attack: isolate John. What did every Senior, sans John, have in common?"

    p "Ugh...my timing on this could have been better..."

    "This stupid class is before lunch! I can't focus at all!"

    p "So...bored. Too...tired..."

    "Curse this teacher's perfectly monotone voice! It's almost a medical sedative."

    "All I could come up with was that Seniors are Seniors (hey, don't judge me!) and that they can drive. The bad part is that John fits those two things perfectly..."

    "At least class was finally done! And my next class is Choir, or more accurately, do-nothing-for-an-hour."

    "I might have failed before, but now I'm ready to go. And, even better, John is also in Choir sitting next to three of his classmates! Perfect!"

    "Let's see here..."

    $ choiceOne = False
    $ choiceTwo = False
    $ choiceThree = False

label actoneChoiceMatrix:
#This is the most ridiculous thing ever...
    if choiceOne:
        if choiceTwo:
            if choiceThree:
                jump actoneCont

    menu:
        "Maybe their clothes..?":
            jump actoneChoiceone
        "Maybe their specific age..?":
            jump actoneChoicetwo
        "Maybe their personal preferences..?":
            jump actoneChoicethree
        "I'm too tired. I give up!!!":
            jump actoneCont
 
label actoneChoiceone:
#This'll be fairly in-depth and should have some superficial but detailed information and analysis, with perhaps a side-tangent or two...
    p "Maybe there's something about their clothes?"
#I'll probably start with some fairly superficial stuff, ya know, make the player think this'll get nowhere...Clothes first
    "Unfortunately, at MY school, there's a dress code. Due to that daily annoyance, wardrobe choices are fairly limited and everyone just ends up wearing the same basic thing."
    $ choiceOne = True
#It'd be cool to throw in something here involving her Choir class, like her teacher calling out her lack of attention or asking her for something...
    "Teacher" "Maya, are you paying attention?"
    p "Agh! I'm sorry!"
    "Teacher" "Don't apologize, just pay more attention and stop DayDreaming."
    "I'm not daydreaming, though, just focusing really hard on something totally unrelated to your class."
    jump actoneChoiceMatrix
 
label actoneChoicetwo:
#This'll be fairly in-depth and should have some superficial but detailed information and analysis, with perhaps a side-tangent or two...
    p "Maybe there's something about how old they are?"
#I'll probably start with some fairly superficial stuff, ya know, make the player think this'll get nowhere...Clothes first
    "Not too difficult. I'm NOT a stalker, but I know their ages down to the month. Bad news, though, as I quickly realized that John was about the same age - in the middle actually."
    $ choiceTwo = True
#It'd be cool to throw in something here involving her Choir class, like her teacher calling out her lack of attention or asking her for something...
    "Teacher" "Maya, can you tell me which note this is?"
    "Trebel Clef...a quarter note...I'm not really sure beyond that...Oh well, just going to have to guess..."
    menu:
        "F?":
            p "Is it 'F'?"
            "Teacher" "Not even close, Maya. Please pay more attention."
            p "Agh! Sorry!"
        "C?":
            p "Is it 'C'?"
            "Teacher" "No it is not, Maya. Are you paying attention?"
            p "Agh! Sorry!"
        "A?":
            p "Is it 'A'?"
            "Teacher" "...Yes, it is 'A', but somehow I doubt you didn't just guess."
            p "I didn't guess."
            "More accurately, I didn't 'NOT' guess."
    jump actoneChoiceMatrix
 
label actoneChoicethree:
#This'll be fairly in-depth and should have some superficial but detailed information and analysis, with perhaps a side-tangent or two...
    p "Maybe there's something about their hobbies?"
#I'll probably start with some fairly superficial stuff, ya know, make the player think this'll get nowhere...Clothes first
    "This at least yielded something not completely obvious. I knew the Senior to John's left enjoyed playing guitar. The one to his right, who just so happened to be Sam, obviously loved Football."
    "John, however, preferred technology...or whatever. He liked stuff with computers. I found it boring, but it wasn't really unusual. Leon was extremely talented in Computer Science. Oh well."
    $ choiceThree = True
#It'd be cool to throw in something here involving her Choir class, like her teacher calling out her lack of attention or asking her for something...
    "Teacher" "Maya, can you sing the solfège for me now? Here's you note:"
    "I hear the teacher play a note on the piano in the room."
    "All I honestly remember about solfège is that you start out low and end up hi, but as for what 'syllables'...what were they again?"
    menu:
        "Do Re Mi So Fa Ti La Do?":
            "I give it my best shot, singing with a kind of confidence I definately don't deserve in this situation."
            "Teacher" "Good try, but the syllables are in the wrong order."
            "And as a result of singing with that 'proud' voice, I am now emarrased as everyone decided to pay attention at that moment. It could have been worse, though."
        "Do Mi So Ti Re La Fa Do?":
            "I give it my best shot, singing with a kind of confidence I definately don't deserve in this situation."
            "Teacher" "Your confidence is great, Maya, but your memory of solfège is pathetic."
            "Well, high-school pro-tip: misplace your confidence in Choir if you want to be extremely embarrased."
            "And that's exactly what happened, because absolutely EVERYONE experienced my poor solfège skills."
        "Do Re Mi Fa So La Ti Do?":
            "I give it my best shot, singing with a kind of confidence I definately don't deserve in this situation."
            "Teacher" "That...was actually amazing, Maya. I guess there's hope for you yet..."
            "Oh, way to be all dramatic about it like I'm a lost cause. This is why I 'love' Choir..."
        "Do Re Mi La So Fa Ti Do?":
            "I give it my best shot, singing with a kind of confidence I definately don't deserve in this situation."
            "Teacher" "Not a bad attempt, but you swapped two of the syllables. Don't worry, Maya. Solfège is taught at every level of Music."
            "Somehow, I managed not to embarrase myself without being correct. That worked out well enough."
    jump actoneChoiceMatrix

label actoneCont:
    "After all of this time, I managed to come up with nothing more than a couple of interesting facts."

    p "Actually, there could be one more thing...I just have to focus..."
    
    "After watching John and his classmates for half an hour, the possibility became a reality..."
#I'm thinking of making this section both longer and more interactive...
    label actonecontchoice:
        menu:
            "The key is their HAIRSTYLE!":
                p "The key...is their hairstyle...no...that just doesn't sound right. John might have bigger hair, but I know it's nothing compared to some of his classmates..."
                "Gotta think of something else, Maya."
                jump actonecontchoice
            "The key is their UNIQUENESS!":
                p "Perhaps...huh."
            "The key is that there's NO KEY!":
                p "The key...doesn't exist? I'd almost expect that kind of thing here, but it doesn't look like it applies here..."
                "Gotta try harder, Maya."
                jump actonecontchoice
#nested labels work! Rejoice!!!
    p "The key...was just so incredibly simple. I couldn't have thought of it. I literally had to stop thinking..."

    p "...to even realize it."

    "It only took 40 minutes, but I finally noticed that every Senior is completely UNIQUE!"

    p "But...John was different in that respect...somehow...like some non-'Kosher' variety of Uniqueness."

    "Every Senior had their own Aura, or rather total personality - a kind of emergent quality..."

    p "That which is 'other' than the sum of the parts...in essence what people essentially 'are'."

    "...but somehow, John's Aura was...'stale', or perhaps maybe even 'stolen' or 'Jerry-rigged'? It's just difficult to describe it..."
#Pace change...
    p "Whatever the word, though, this has to be it. Even though small, my victory is at hand! At that moment, the bell rang, beginning the best 'class' of all time: Dismissal."

    p "I don't know why, but so many of my friends just want to go home the moment the bell rings. There's literally no time during school to talk, anyway. Why go home NOW?"

    "No, this time should be used to the maximum extent: this was the reason to even come to school in the first place - nay, the reason to get up in the morning!"
#This is where the Gossip System is born. Whether or not I'll let the player know what it's called or even when or how is undetermined as of now. This will ultimately drive the rest of the game, however.
    p "It really is like a system. Sure, talking and gossiping doesn't really happen much during the actual day, but Dismissal is the absolute best for this kind of thing!"

    "I can talk to basically anyone and, given the right amount of nudging, learn almost anything I could want to know about anybody. Wikipedia, eat your heart out!"

label acttwo2:
    "Act Two"
    
    p "I'm ready for today...kinda."
    
    "It's not the most accurate statement, for obvious reasons..."
    
    p "Some of my classes, though..."
    
    "Home-ec was easy and - somehow - interesting."
    "History: not interesting. Not even close."
    "Biology is pointlessly complicated; it's the only class I'm retaking!"
    "And, of course, English. Literally a Death March."
    
    p "To be more accurate, there is only one thing I actually care about."
    
    "After yesterday's retrospectively small breakthrough, it was time to begin interrogation."
    
    p "It's a good thing I can still relate to the Freshman, at least a little."
    
    "There's so many of them; I think they outnumber us by almost double! Of course, there's still a problem here..."
    
    p "Problem: they're Freshmen."
    
    "They would love to gossip to 'any' upperclassman, but they might not provide any kind of useful information, willingly or not."
    
    p "Obviously, my choice of words in this situation will be vital."
    
    d "Now that everything above is in good condition, it's about time for Scene 2 to finally get completed."
    d "There's about a paragraph, at least right now. That's it. Most of this story is unwritten; I literally have nothing more to convert from ChoiceScript! Yay!"
    d "On the other hand, the story doesn't exist after that, so I might have a tad more in that fancy Notebook I have, but there really isn't much. All in all, this could go in any direction..."
    d "But I digress."

label end: 
    d "Thanks for your time!  Currently, All of the Introduction and Act One are complete, at least in their current form." 
    d "As you've probably noticed, there are no art assets." 
    d "Act two begins the main game. I've finally gotten around to it, but only with material I already have." 
    d "Until then, thanks again for your time. Sayonara!"
    

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    