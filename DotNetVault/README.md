# DotNetVault
Synchronization Library and Static Analysis Tool for C# 8

Advantages:

​	**Deadlock avoidance**: by default, all locks are timed.  If the resource has already been obtained or you have accidentally changed the acquisition order of various locks somewhere in the code, you get a *TimeoutException*, allowing you to identify your mistake.  In addition to being able to base termination of an acquisition attempt on timeout, you can also use a cancellation token to propagate the cancellation request.

​    **RAII (Scope-based) Lock Acquisition and Release:**  Locks are stack-only objects (ref structs) and the integrated Roslyn analyzer forces you to declare the lock inline in a using statement or declaration, or it will cause a compilation error.  There is no danger of accidentally holding the lock open longer than its scope even in the presence of an exception or early return.

   **Isolation of Protected Resources**:  The need for programmer discipline is reduced:	
    1. programmers do not need to remember which mutexes protect which resources,
    2. programmers cannot access the protected resource before they obtain the lock and cannot access any mutable state from the protected resource after releasing the lock,
    3. static analysis rules enforced by compilation errors emitted from the integrated Roslyn analyzer prevent references to mutable state from outside the protected resource from becoming part of the protected resource and prevent the leaking of references to mutable state inside the protected resource to the outside.

See **Pdf for full description of this project.**

RELEASE NOTES VERSION 0.1.4.1:

    Added quick start guide pdf and project (project available on GitHub).

    Updated readme.md

RELEASE NOTES VERSION 0.1.4.0:
    
    Bug# 61 FIXED.  Double dispose is now practically impossible.  Analyzer now forbids out of line, pre-declaration of a variable that will be the subject of a using statement or declaration.  Analysis rules now prevent manual calls to Dispose method and additional method and analysis rules were added to account for the two use-cases where manual release of protected resource is necessary.  These rules make it difficult to accidentally use the new manual release method accidentally.
    
    Bug# 62 FIXED.  Analysis now considers call of extension method using extension method syntax to be equivalent to a call thereto using static syntax.
    
    Bug# 48 Fields in base classes were not being considered in vault safety analysis.  An otherwise fine sealed class could be considered vault safe despite fields in a base clase violating vault-safety rules.
    
    Bug# 48 FIXED.  Analyzer now considers all fields from base classes when performing vault-safety analysis.  If a base class has field that, if present in sealed derived class being analyzed for vault-safety, would prevent the sealed derived class from being considered vault-safe, the sealed derived class will not be considered vault-safe.  A derived class, however, will not be considered not vault-safe MERELY because it inherits from a base class.  This change to the analyzer, does not, however, permit the base classes themselves to be used in a vault-safe context.
    
    Laundry machine simulation can go significantly more quickly now.  With parameters of 1, 2, and 3 milliseconds and 200 laundry articles, the test completes on my pc in less than two minutes.  It no longer sleeps during task simulation if the timespan parameters entered are small enough that the sleeping will cause the tasks to take much longer than the parameters specified.  
    
    A few convenience-based changes were made to the LaundryMachine simulation and the ConsoleStressTest.  Code in the ExampleCodePlayground, ConsoleStressTest and LaundryStessTest projects was updated to comply with new analysis rules as needed.
    
    The console stress test now outputs whether the time stamps it gathers are based on a high precision timer or not.
    
    Unit tests were added to the unit test project that validate the new analyis rules.
    
    The pdf documentation was edited and updated based on the foregoing changes.
    
    Xml Doc Comments for DotNetVault analyzer/library are now included in the NuGet package.

RELEASE NOTES VERSION 0.1.3.13:

    Fixed two flaws in the ConsoleStressTest.  
    
    The default ordering comparer for stress test logic now considers ThreadId, then Action Number, then TimeStamp, then Text. 
    
    It now takes linearithmic rather than quadratic time to process and validate the results of the Console Stress test.
    
    Added a table of know flaws and issues to the pdf documentation.  Code examples shown for these flaws now appear in the ExampleCodePlayground as well.