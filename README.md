<h1>What & Why?</h1>
<p>AutoParse is a simple wrapper to .NET's <i>TryParse</i> methods that are found on many of the standard types.  It takes away the need to use the <i>out</i> parameters and also provides an overload for custom parsing.</p>
<br/>
<p>Typical tryparse usage looks like this:</p>
<pre>
	<code>
		int number;
		if(int.TryParse("123456", out number))
			// we parsed
		else
			// we didn't
	</code>
</pre>
<br/>
<p>In cases where you don't really have any conditional logic, but don't want to fail if the value cannot be parsed, AutoParse simplifies it:</p>
<pre>
	<code>
		var number = "123456".Parse&lt;int&gt;();
	</code>
</pre>