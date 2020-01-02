# Memory Garden
A gamified photo album application to help [dementia](https://en.wikipedia.org/wiki/Dementia) patients in the world.

## 1. Introduction
### 1.1 The topic
[Applied Game Jams](https://vimeo.com/154570227) are game jams around a specific socio-economic or environmental theme.
The given topic of the Global Applied Game Jam 2018 @ POSTECH was dementia.

### 1.2 Rationale
Our team [Neuro](https://www.facebook.com/GameNeuro/) focused on the betterment of the dementia symptoms.
Researches show that more intimate relationship between a patient and a caregiver improves the symptoms from dementia.
We came up with an idea of a shared photo album between a patient and a caregiver, which could work as a reminder of
memories shared between the two and a bond of the relationship.

### 1.3 Idea
> 1. Providing visual and auditory feedback to relocate memories of the patients.
> 2. Using a PHP server for authentication and binding of a patient and a caregiver.

<hr/>

## 2. The Game

<img src="https://scontent-icn1-1.xx.fbcdn.net/v/t1.0-9/s960x960/38192007_307025136520794_5176965179857960960_o.jpg?_nc_cat=110&_nc_ohc=iFivT179Zx8AQlj7UP026v0-os9ly4ckZrwERoZognkieJaADZ8HgeU_A&_nc_ht=scontent-icn1-1.xx&oh=75bacbe93247c1ed978b7cbf023bc47f&oe=5E6B6604" width="595px" height="769px" title="" alt=""></img>

### 2.1 Screenshot
<img src="https://media.giphy.com/media/TGcYg4qJ9Bk39bev8c/giphy.gif" title="" alt=""></img>

### 2.2 Gameplay
* **The Garden**

<img src="https://media.giphy.com/media/UsLz4sLODAwy2P1k9i/giphy.gif" title="" alt=""></img>

When a caregiver uploads short (~30 seconds) video clips to the server, it will automatically be loaded to the patient's client.
The new videos will be shown as flowers at the top header. When a patient clicks one of the flowers, the game will proceed
to the photo book scene.

* **The Photobook**

<img src="https://i.imgur.com/VUOoJTf.png" title="" alt=""></img>

The patient should distinguish one of the three video clip that has a matching audio.
Three video clips and its respective audios are automatically loaded from the server and randomized among themselves.
By clicking the thumbnail of the video clips, the video will run while playing a randomized audio, for the first 5 seconds.
The patient should select one of the **right** clips by clicking the red button.

* **The Memories**

<img src="https://i.imgur.com/BtTBcs3.jpg" title="" alt=""></img>

If a right video clip is chosen, the application will play the full video clip with a immersive fade at the background.

<img src="https://media.giphy.com/media/TH5nemPPKoL2zteDs6/giphy.gif" title="" alt=""></img>

When the video clip ends, the patient will receive a short letter which is written by the caregiver.
By touching the flower, the patient will be directed to The Garden.

<img src="https://media.giphy.com/media/WpaVmj5Llro4y8yboW/giphy.gif" title="" alt=""></img>

The collected flowers can be planted on the garden, which later can be clicked again to replay the video and the letter.

<hr/>

## 3. Credits
* Programmer: [Sergi van Ravenswaay](https://www.facebook.com/sergi.vanravenswaay)
* Programmer: [Sean (Sang-Uk) Lee](https://github.com/sean-sanguk-lee)
* Artist: [임수환](https://www.facebook.com/profile.php?id=100013656583498)
* Artist: [---](---)
* Musician: [Takumi Ochi](https://www.facebook.com/profile.php?id=100005139965172)
* This readme is writen by Sean (Sang-Uk) Lee
