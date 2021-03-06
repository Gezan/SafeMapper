Speed tests
=============

Converting 100000 strings to int with strings containing valid integers

    SafeMapper:      3.0 ms
    int.Parse:       9.0 ms
    EmitMapper:     13.3 ms
    ValueInjector:  23.6 ms
    FastMapper:     40.8 ms
    AutoMapper:     78.4 ms

NOTE: SafeMapper is faster than int.Parse because it uses an alternative int parse based on the IntParseFast found here http://www.dotnetperls.com/unsafe-parse with some additional checks for negative numbers and valid numeric characters.

To prove the importance of not throwing exeptions in the conversion here is an example with try catch around each conversion.

Converting 100000 strings to int with strings containing invalid characters

    SafeMapper:      2.3 ms
    int.TryParse:    9.4 ms
    ValueInjector:  25.6 ms
    AutoMapper:     72.5 ms
    int.Parse:    2318.9 ms
    EmitMapper:   2714.4 ms
    FastMapper:   2887.5 ms

It is easy to see which mappers that does throw exception on invalid conversions