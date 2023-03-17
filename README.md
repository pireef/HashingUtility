# Hashing Utility

This is a simple little program that will compute hash values of a file.  Currrently it will compute MD5, SHA1, SHA256, SHA384, and SHA512.

3-17-2023 Update

The hashes are now all run in different threads.  This definitely speeds up / improves resposiveness on large files.  

# Future Development Ideas
 
- Recursive hashing of all files and subfolders in a directory.  I have the proof of concept working for this, just need to figure out how I want to integrate it.
- Integrate with NISRL
- Integrate with VirusTotal through their API.  
