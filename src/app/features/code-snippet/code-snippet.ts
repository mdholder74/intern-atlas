import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-code-snippet',
  standalone: false,
  templateUrl: './code-snippet.html',
  styleUrl: './code-snippet.css',
})
export class CodeSnippet {
  @Input() title?: string;
  @Input() code: string = '';

  copyToClipboard(): void {
    navigator.clipboard
      .writeText(this.code)
      .then(() => {
        console.log('Code copied to clipboard');
      })
      .catch((err) => {
        console.error('Failed to copy code: ', err);
      });
  }
}
