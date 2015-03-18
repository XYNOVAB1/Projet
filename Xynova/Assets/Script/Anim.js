public var object: GameObject; // L'objet à animer
public var animStop: AnimationClip; // Le fichier d'animation
public var animForward: AnimationClip;
public var animBack: AnimationClip;
public var animLeft: AnimationClip;
public var animRight: AnimationClip;

function Start() {
	object.animation.clip = animStop;
	object.animation.Play();
}

function Update() {
    
    if(Input.GetKey(KeyCode.UpArrow)) {
    	object.animation.clip = animBack;
    	object.animation.Play();     	
    }
    
    if(Input.GetKey(KeyCode.DownArrow)) {
    	object.animation.clip = animForward;
    	object.animation.Play();     	
    }
    
    if(Input.GetKey(KeyCode.LeftArrow)) {
    	object.animation.clip = animLeft;
    	object.animation.Play();     	
    }
    
    if(Input.GetKey(KeyCode.RightArrow)) {
    	object.animation.clip = animRight;
    	object.animation.Play();
    }
    
}