﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager{

	//Got a tetris
	public delegate void Tetris();
	public static event Tetris GotTetris;

	public static void GoTetris(){
		if(GotTetris != null){
			GotTetris();
		}
	}

	//Check if tetris
	public delegate void Check();
	public static event Check CheckTetris;

	public static void Checker(){
		if(CheckTetris != null){
			CheckTetris();
		}
	}

	//Got Game over
	public delegate void Loss();
	public static event Loss LostGame;

	public static void GameOver(){
		if(LostGame != null){
			LostGame();
		}
	}

	//Drop the next block
	public delegate void Drop();
	public static event Drop BlockDrop;

	public static void DropBlock(){
		if(BlockDrop != null){
			BlockDrop();
		}
	}
}
