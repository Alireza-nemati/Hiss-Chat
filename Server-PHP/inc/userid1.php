<?php

if(isset($_POST["token"]) && !empty($_POST["token"])){

	$token = $_POST["token"];

	
	try{
		$ex = explode("</>",Code('de',$token));	
	}catch(Exception $e){
	
		echo "0";
		exit();
	}

	@$user = $ex[0];

		echo $user ;

	

		
	}else{
		
		echo "0";
	
	}
	


?>
