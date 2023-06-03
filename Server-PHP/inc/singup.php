<?php
$token = "";
if(
isset($_POST['user']) && !empty($_POST['user']) &&
isset($_POST['pass']) && !empty($_POST['pass']) &&
isset($_POST['email']) && !empty($_POST['email']) && 
(filter_var($_POST['email'], FILTER_VALIDATE_EMAIL))
){
	$user = $_POST['user'];
	$pass = $_POST['pass'];
	$email = $_POST['email'];
	@$data = json_decode(file_get_contents('data/db.json'),true);
	if(!isset($data[$user])){
		if(strlen($pass) >= 6) {
			$data[$user] = ['password' => $pass,'email'=>$email];
		file_put_contents('data/db.json',json_encode($data));
		echo "1";
		}else{
			echo "0";
		}
		
	}else{
		echo "0";
	}
}
else{
	echo "0";
}	
?>
