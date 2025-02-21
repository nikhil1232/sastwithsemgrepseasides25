<?php  

function callsystem($command){  
system($command);
exec($command);
}  

$command = "ls ".$_GET['modifiers'];
callsystem($command);