<?php  

function pregfunc($userinput)
{  
echo preg_replace('/(.*)/e', 'strtoupper("\\1")', $userinput);
}  


function pregfuncregex($userinputreg, $userinput)
{  
echo "--- Execution Starts ---";
echo preg_replace($userinputreg, 'strtoupper("\\1")', $userinput);
echo "--- Execution Stops ---";
}  

$userinput = $_GET['search'];
$userinputreg = $_GET['reg'];
pregfunc($userinput);
pregfuncregex($userinputreg, $userinput);

?>