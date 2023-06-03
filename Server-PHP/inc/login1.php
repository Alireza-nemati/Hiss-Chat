<?php

if(isset($_POST["token"]) && !empty($_POST["token"])){

	$token = $_POST["token"];

	
	try{
		$ex = explode("</>",Code('de',$token));	
	}catch(Exception $e){
	
		echo "0";
		exit();
	}
	@$data = json_decode(file_get_contents('data/db.json'),true);
	@$user = $ex[0];
	if(isset($data[$user])){
		if(@$ex[1] == $data[$user]['password']){
		echo "1";
		}else{
		
		echo "0";
	
	}
		
	}else{
		
		echo "0";
	
	}
	
	
	}else{
		echo "0";
}

?>
