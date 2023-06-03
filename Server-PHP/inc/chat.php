<?php


if(
	check($_POST['forum']) &&
	check($_POST['id']) &&
	check($_POST['msg']) 
){
	$forum = $_POST['forum'];
	$id = $_POST['id'];
	$msg = base64_decode($_POST['msg']);
if(file_exists('data/forum/'.$forum.'.json')){
	$chat_log = json_decode(file_get_contents('data/forum/'.$forum.'.json'),true);
	$r_line = str_replace(array("\n", "\r"), '', $msg);
	$msg = trim( str_replace( PHP_EOL, '', $r_line ) );
	$chat_log[] = array($id , $msg); 
	//mb_convert_encoding($text, 'UTF-8', $msg);
	//file_put_contents('a.txt',$msg);
	file_put_contents('data/forum/'.$forum.'.json',json_encode($chat_log,JSON_UNESCAPED_UNICODE));
	if($msg == "/rest" && $id == "alireza"){
		file_put_contents('data/forum/'.$forum.'.json',"");
	}
	echo '1';
}else{
	echo '0';
}
}else{
	echo '0';
}





 ?>
