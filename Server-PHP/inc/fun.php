<?php

function Check($data){
	if(isset($data) && !empty($data)){
		return true;
	}else{ return false;}
}

function Code($action, $string) {
    $output = false;
    $encrypt_method = "AES-256-CBC";
    $secret_key = 'Y29kZSBieSBhbGlyZXphIG5lbWF0aQ';
    $secret_iv = 'cG93ZXIgb2YgYWxpcmV6YSBuZW1hdGk';
    // hash
    $key = hash('sha256', $secret_key);
    // iv - encrypt method AES-256-CBC expects 16 bytes - else you will get a warning
    $iv = substr(hash('sha256', $secret_iv), 0, 16);
    if ( $action == 'en' ) {
        $output = openssl_encrypt($string, $encrypt_method, $key, 0, $iv);
        $output = base64_encode($output);
    } else if( $action == 'de' ) {
        $output = openssl_decrypt(base64_decode($string), $encrypt_method, $key, 0, $iv);
    }
    return $output;
}