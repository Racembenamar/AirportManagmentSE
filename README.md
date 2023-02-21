<!DOCTYPE html>
<html>
<head>

</head>
<body>
  <header>
    <h1>Airport Management</h1>
  </header>
  <main>
    <p>This project aims to create a management application for airport activities, as defined by the class diagram below.</p>
    <img src="https://www.linkpicture.com/q/Tables-removebg-preview.png">
    <h2>I Implementation of the Data Layer</h2>
    <ol>
      <li>
        Create a solution named "AirportManagement" that contains the following two projects:
        <ul>
          <li>AM.UI.Console: Console Application (.NET 6.0) project</li>
          <li>AM.ApplicationCore: Class Library (.NET 6.0) project</li>
        </ul>
        Note that the Console project must reference the ApplicationCore project.
      </li>
      <li>Under the AM.ApplicationCore project, create a folder called "Domain" and implement the various classes from the class diagram above.</li>
      <li>Represent inheritance between the Passenger class and the two Staff and Traveller classes.
        <ul>
          <li>For example, the 1-* relationship between Plane and Flight will be represented by the following navigation objects:
            <ul>
              <li>A ICollection&lt;Flight&gt; property in the Plane class</li>
              <li>A Plane property in the Flight class</li>
            </ul>
          </li>
        </ul>
      </li>
    </ol>
    
    
    
  </main>
</body>
</html>
