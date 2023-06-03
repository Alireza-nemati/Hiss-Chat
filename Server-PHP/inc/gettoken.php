<?php


if(
(isset($_POST["user"]) && !empty($_POST["user"])) &&
(isset($_POST["pass"]) && !empty($_POST["pass"]))
){

	$user = $_POST["user"];
	$pass = $_POST["pass"];
	
	$data = json_decode(file_get_contents('data/db.json'),true);
	if(isset($data[$user])){
		if($pass == $data[$user]['password']){
		echo Code('en', $user."</>".$pass);
		}else{
		
		echo "0";
	
	}
		
	}else{
		
		echo "0";
	
	}
	
	}else{
		echo "0";
}