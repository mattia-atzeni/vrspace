﻿#pragma strict
 
var walk : AudioClip;
var run : AudioClip;
 
var isWalking : boolean = false;
var isRunning : boolean = false;
var jetpackOn : boolean = false;
 
 
function Update() 
{
    GetState();
    PlayAudio();
}
 
 
function GetState() 
{
	if(!jetpackOn){
    if ( Input.GetAxis( "Horizontal" ) || Input.GetAxis( "Vertical" ) )
    {
        if ( Input.GetKey( "left shift" ) || Input.GetKey( "right shift" ) )
        {
            // Running
            isWalking = false;
            isRunning = true;
        }
        else
        {
            // Walking
            isWalking = true;
            isRunning = false;
        }
        }
    else
    {
        // Stopped
        isWalking = false;
        isRunning = false;
    }
    }
    if(jetpackOn)
    {
    	if ( Input.GetAxis( "Horizontal" ) || Input.GetAxis( "Vertical" ) || Input.GetMouseButton(0) || Input.GetMouseButton(1) )
    	{
    		isWalking = true;
    		isRunning = false;
    	}
    	else 
    	{
    		isWalking = false;
    		isRunning = false;
    	}
    }
    
}
 
 
function PlayAudio() 
{
    if ( isWalking )
    {
        if ( audio.clip != walk )
        {
            audio.Stop();
            audio.clip = walk;
        }
 
        if ( !audio.isPlaying )
        {
            audio.Play();
        }
    }
    else if ( isRunning )
    {
        if ( audio.clip != run )
        {
            audio.Stop();
            audio.clip = run;
        }
 
        if ( !audio.isPlaying )
        {
            audio.Play();
        }
    }
    else
    {
        audio.Stop();
    }
}