<?php
//header('Content-type: text/plain; charset=utf-8'); 
//ini_set('default_charset', 'UTF-8');
include "inc/fun.php";
if(@Check($_GET['com'])){
	$com = $_GET['com'];
	switch($com){
		case"update": include "inc/update.php"; break;
		case"chat": include "inc/chat.php"; break;
		case"login1": include "inc/login1.php"; break;
		case"login2": include "inc/login2.php"; break;
		case"gettoken": include "inc/gettoken.php"; break;
		case"userid1": include "inc/userid1.php"; break;
		case"userid2": include "inc/userid2.php"; break;
		case"singup": include "inc/singup.php"; break;
	}
}else{
	echo 0;
}
	?>
