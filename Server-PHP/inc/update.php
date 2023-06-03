<?php  
if(@check($_GET['d'])){
$d = $_GET['d'];
switch($d){
	case"update":
	if(@check($_POST['forum'])){

	$forum = $_POST["forum"];	
	
	$data = json_decode(file_get_contents('data/forum/'.$forum.'.json'),true);
	
	echo count($data);
	
	}else{
		echo "0";
}
break;
case"log":
if(@check($_POST['forum'])){
if($_POST['id']==""){
	$id_msg = 0;
}else{
	$id_msg = $_POST['id'];
}
	$forum = $_POST["forum"];	
	$data = json_decode(file_get_contents('data/forum/'.$forum.'.json'),true);
	if(isset($data[0][0])){
	$r_line = str_replace(array("\n", "\r"), '', $data[$id_msg][0]." : ".$data[$id_msg][1]);
	echo  trim( str_replace( PHP_EOL, '', $r_line ) );
	}else{var_dump($data);
		echo "0";
	}
}else{
	echo "0";
}
break;
}
}