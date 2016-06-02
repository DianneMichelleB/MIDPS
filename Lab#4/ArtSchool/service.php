<?php

if($_POST){
	if ($_POST['action'] == 'addRunner') {

		$fname = htmlspecialchars($_POST['txtFirstName']);
		$lname = htmlspecialchars($_POST['txtLastName']);
		$gender = htmlspecialchars($_POST['ddlGender']);
		$email = htmlspecialchars($_POST['txtYourEmail']);
		if(preg_match('/[^\w\s]/i', $fname) || preg_match('/[^\w\s]/i', $lname)) {
			fail('Invalid name provided.');
		}
		if( empty($fname) || empty($lname) ) {
			fail('Please enter a first and last name.');
		}


		if( empty($email) ) {

			fail('Please enter an email.');
	}
	if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
	fail('Please enter a valid email.'); // Or another handler
	}

		if( empty($gender) ) {
			fail('Please select a gender.');
		}



		$query = "INSERT INTO students SET first_name='$fname', last_name='$lname', gender='$gender', email='$email'";
		$result = db_connection($query);

		if ($result) {
			$msg = "Runner: ".$fname." ".$lname." added successfully" ;
			success($msg);
		} else {
			fail('Insert failed.');
		}
		exit;
	}
}

if($_GET){
	if($_GET['action'] == 'getRunners'){
		$query = "SELECT first_name, last_name, gender, email FROM students order by first_name ASC ";
		$result = db_connection($query);

		$runners = array();

		while ($row = mysql_fetch_array($result, MYSQL_ASSOC)) {
			array_push($runners, array('fname' => $row['first_name'], 'lname' => $row['last_name'], 'gender' => $row['gender'], 'email' => $row['email'], ));
		}
		echo json_encode(array("runners" => $runners));
		exit;
	}
}
	function db_connection($query) {
		mysql_connect('localhost', 'root', '')
			OR die(fail('Could not connect to database.'));
		mysql_select_db('pizza_info');

		return mysql_query($query);
	}

	function fail($message) {
		die(json_encode(array('status' => 'fail', 'message' => $message)));
	}
	function success($message) {
		die(json_encode(array('status' => 'success', 'message' => $message)));
	}
?>
